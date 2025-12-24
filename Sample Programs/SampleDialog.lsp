
;=============================================================================================================================================================================================
;=============================================================== SampleDialog.lsp ============================================================================================================
;=============================================================================================================================================================================================
; This program creates and displays a sample dialog box using embedded DCL in AutoLisp
; To use this program, load it into AutoCAD and run the command 'SampleDialog'.

(defun c:SampleDialog ( / DCL_Name DCL_Text DCL_File DCL_ID)
  
  ; Replace DialogBoxName with your desired actual dialog box name
  
  (setq DCL_Name (vl-filename-mktemp "DialogBoxName.dcl"))                                    ; Create a temporary DCL file name
  (setq DCL_Text (DCL-Text-Function))                                                         ; Get the DCL text from the function
  (setq DCL_File (open DCL_Name "w"))                                                         ; Open the temporary DCL file for writing
  (write-line DCL_Text DCL_File)                                                              ; Write the DCL text to the file
  (close DCL_File)                                                                            ; Close the DCL file
  
  (setq DCL_ID (load_dialog DCL_Name))                                                        ; Load the DCL file and get its ID
  (if (not (new_dialog "DialogBoxName" DCL_ID))                                               ; Create a new dialog instance
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

    "DialogBoxName : dialog {\n"
    "  label = \"Sample Dialog\";\n"
    "  spacer;\n"
    "  : boxed_column {\n"
    "    label = \"Sample Options\";\n"
    "    : row {\n"
    "      : toggle {key = \"A\"; label = \"Option A\"; alignment = left; fixed_width = true; width = 25;}\n"
    "      : toggle {key = \"B\"; label = \"Option B\"; alignment = left; fixed_width = true; width = 25;}\n"
    "    }\n"
    "  }\n"
    "  spacer;\n"
    "  ok_cancel;\n"
    "}\n"

    )
  )
  DCL_Text
)
