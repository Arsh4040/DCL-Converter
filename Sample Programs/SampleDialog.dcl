DialogBoxName : dialog {
  label = "Sample Dialog";
  spacer;
  : boxed_column {
    label = "Sample Options";
    : row {
      : toggle {key = "A"; label = "Option A"; alignment = left; fixed_width = true; width = 25;}
      : toggle {key = "B"; label = "Option B"; alignment = left; fixed_width = true; width = 25;}
    }
  }
  spacer;
  ok_cancel;
}