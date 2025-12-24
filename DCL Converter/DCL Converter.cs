using System;
using System.Windows.Forms;
    
namespace DCL_Converter
{
    public partial class DCL_Converter : Form
    {

// Global readonly string for header
private readonly string header = @"
;=============================================================================================================================================================================================
;=============================================================== SampleDialog.lsp ============================================================================================================
;=============================================================================================================================================================================================
; This program creates and displays a sample dialog box using embedded DCL in AutoLisp
; To use this program, load it into AutoCAD and run the command 'SampleDialog'.

(defun c:SampleDialog ( / DCL_Name DCL_Text DCL_File DCL_ID)
  
  ; Replace DialogBoxName with your desired actual dialog box name
  
  (setq DCL_Name (vl-filename-mktemp ""DialogBoxName.dcl""))                                    ; Create a temporary DCL file name
  (setq DCL_Text (DCL-Text-Function))                                                         ; Get the DCL text from the function
  (setq DCL_File (open DCL_Name ""w""))                                                         ; Open the temporary DCL file for writing
  (write-line DCL_Text DCL_File)                                                              ; Write the DCL text to the file
  (close DCL_File)                                                                            ; Close the DCL file
  
  (setq DCL_ID (load_dialog DCL_Name))                                                        ; Load the DCL file and get its ID
  (if (not (new_dialog ""DialogBoxName"" DCL_ID))                                               ; Create a new dialog instance
    (exit)                                                                                    ; Exit if dialog creation fails
  )
  
  ; Dialog control code can be added here if needed
  
  (start_dialog)                                                                              ; Start the dialog box interaction
  (unload_dialog DCL_ID)                                                                      ; Unload the dialog after it's closed
  (vl-file-delete DCL_Name)                                                                   ; Delete the temporary DCL file
  (princ)                                                                                     ; Exit quietly
)


;=============================================================================================================================================================================================
;==================================================================== DCL-Text-Function ======================================================================================================
;=============================================================================================================================================================================================
; This function define the DCL dialog code
; Function Syntax: (DCL-Text-Function)
; Function Parameters: None
; Function Returns: A string containing the DCL dialog text definition.

(defun DCL-Text-Function ( / DCL_Text)
  (setq DCL_Text
    (strcat
";

// Global readonly string for footer
private readonly string footer = @"
    )
  )
  DCL_Text
)
";
        public DCL_Converter()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select a DCL file";
            openFileDialog1.Filter = "DCL files (*.dcl)|*.dcl|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string inputFile = textBoxFilePath.Text;
            if (File.Exists(inputFile))
            {
                // Step 1: Read lines and replace quotes
                var formattedLines = File.ReadAllLines(inputFile)
                .Where(line => !string.IsNullOrWhiteSpace(line))  // Remove empty whitespace lines
                .Select(line => "    \"" + line.Replace("\"", "\\\"") + "\\n\"");


                // Step 2: Join all
                string body = string.Join(Environment.NewLine, formattedLines);

                // Step 3: Add header and footer text
                string output = header + Environment.NewLine + body + Environment.NewLine + footer;

                // Step 4: Save
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Lisp files (*.lsp)|*.lsp|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save converted file as";
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(inputFile) + ".lsp";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, output);

                    // Open the saved file with the default program
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = saveFileDialog1.FileName,
                        UseShellExecute = true
                    });

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("File not found or not selected.");
            }
        }

    }
}