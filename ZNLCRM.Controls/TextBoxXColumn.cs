using System;
using System.Windows.Forms;

namespace ZNLCRM.Controls
{
    public class TextBoxXColumn : DataGridViewColumn
    {
        private DevComponents.Editors.InputButtonSettings buttonCustom;
        //private DevComponents.Editors.InputButtonSettings buttonCustom2;
        private bool includePrompt;
        private bool includeLiterals;
        private Type validatingType;

        public event EventHandler ButtonCustomClick;
        //  Initializes a new instance of this class, making sure to pass
        //  to its base constructor an instance of a TextBoxXCell 
        //  class to use as the basic template.
        public TextBoxXColumn()
            : base(new TextBoxXCell())
        {
            buttonCustom = new DevComponents.Editors.InputButtonSettings();
        }

        //  Routine to convert from boolean to DataGridViewTriState.
        private static DataGridViewTriState TriBool(bool value)
        {
            return value ? DataGridViewTriState.True
                         : DataGridViewTriState.False;
        }

        public void OnButtonCustomClick(object sender,EventArgs e)
        {
            if (this.ButtonCustomClick != null)
            {
                this.ButtonCustomClick(this, e);
            }
        }
        //  The template cell that will be used for this column by default,
        //  unless a specific cell is set for a particular row.
        //
        //  A TextBoxXCell cell which will serve as the template cell
        //  for this column.
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }

            set
            {
                //  Only cell types that derive from TextBoxXCell are supported as the cell template.
                if (value != null && !value.GetType().IsAssignableFrom(typeof(TextBoxXCell)))
                {
                    string s = "Cell type is not based upon the TextBoxXCell.";//CustomColumnMain.GetResourceManager().GetString("excNotTextBoxX");
                    throw new InvalidCastException(s);
                }

                base.CellTemplate = value;
            }
        }


        //   Indicates whether any unfilled characters in the mask should be
        //   be included as prompt characters when somebody asks for the text
        //   of the TextBoxX for a particular cell programmatically.
        // 
        //   See the TextBoxX control documentation for more details.
        public virtual bool IncludePrompt
        {
            get
            {
                return this.includePrompt;
            }
            set
            {
                TextBoxXCell tbxc;
                DataGridViewCell dgvc;
                int rowCount;

                if (this.includePrompt != value)
                {
                    this.includePrompt = value;

                    //
                    // first, update the value on the template cell.
                    //
                    tbxc = (TextBoxXCell)this.CellTemplate;
                    tbxc.IncludePrompt = TriBool(value);

                    //
                    // now set it on all cells in other rows as well.
                    //
                    if (this.DataGridView != null && this.DataGridView.Rows != null)
                    {
                        rowCount = this.DataGridView.Rows.Count;
                        for (int x = 0; x < rowCount; x++)
                        {
                            dgvc = this.DataGridView.Rows.SharedRow(x).Cells[x];
                            if (dgvc is TextBoxXCell)
                            {
                                tbxc = (TextBoxXCell)dgvc;
                                tbxc.IncludePrompt = TriBool(value);
                            }
                        }
                    }
                }
            }
        }

        //  Controls whether or not literal (non-prompt) characters should
        //  be included in the output of the Text property for newly entered
        //  data in a cell of this type.
        // 
        //  See the TextBoxX control documentation for more details.
        public virtual bool IncludeLiterals
        {
            get
            {
                return this.includeLiterals;
            }
            set
            {
                TextBoxXCell tbxc;
                DataGridViewCell dgvc;
                int rowCount;

                if (this.includeLiterals != value)
                {
                    this.includeLiterals = value;

                    //
                    // first, update the value on the template cell.
                    //
                    tbxc = (TextBoxXCell)this.CellTemplate;
                    tbxc.IncludeLiterals = TriBool(value);

                    //
                    // now set it on all cells in other rows as well.
                    //
                    if (this.DataGridView != null && this.DataGridView.Rows != null)
                    {

                        rowCount = this.DataGridView.Rows.Count;
                        for (int x = 0; x < rowCount; x++)
                        {
                            dgvc = this.DataGridView.Rows.SharedRow(x).Cells[x];
                            if (dgvc is TextBoxXCell)
                            {
                                tbxc = (TextBoxXCell)dgvc;
                                tbxc.IncludeLiterals = TriBool(value);
                            }
                        }
                    }
                }
            }
        }

        //  Indicates the type against any data entered in the TextBoxX
        //  should be validated.  The TextBoxX control will attempt to
        //  instantiate this type and assign the value from the contents of
        //  the text box.  An error will occur if it fails to assign to this
        //  type.
        //
        //  See the TextBoxX control documentation for more details.
        public virtual Type ValidatingType
        {
            get
            {
                return this.validatingType;
            }
            set
            {
                TextBoxXCell tbxc;
                DataGridViewCell dgvc;
                int rowCount;

                if (this.validatingType != value)
                {
                    this.validatingType = value;

                    //
                    // first, update the value on the template cell.
                    //
                    tbxc = (TextBoxXCell)this.CellTemplate;
                    tbxc.ValidatingType = value;

                    //
                    // now set it on all cells in other rows as well.
                    //
                    if (this.DataGridView != null && this.DataGridView.Rows != null)
                    {
                        rowCount = this.DataGridView.Rows.Count;
                        for (int x = 0; x < rowCount; x++)
                        {
                            dgvc = this.DataGridView.Rows.SharedRow(x).Cells[x];
                            if (dgvc is TextBoxXCell)
                            {
                                tbxc = (TextBoxXCell)dgvc;
                                tbxc.ValidatingType = value;
                            }
                        }
                    }
                }
            }
        }

        public virtual DevComponents.Editors.InputButtonSettings ButtonCustom
        {
            get
            {
                return this.buttonCustom;
            }
            set
            {
                TextBoxXCell tbxc;
                DataGridViewCell dgvc;
                int rowCount;

                if (this.buttonCustom != value)
                {
                    this.buttonCustom = value;

                    //
                    // first, update the value on the template cell.
                    //
                    tbxc = (TextBoxXCell)this.CellTemplate;
                    tbxc.ButtonCustom = value;
                    //
                    // now set it on all cells in other rows as well.
                    //
                    if (this.DataGridView != null && this.DataGridView.Rows != null)
                    {
                        rowCount = this.DataGridView.Rows.Count;
                        for (int x = 0; x < rowCount; x++)
                        {
                            dgvc = this.DataGridView.Rows.SharedRow(x).Cells[x];
                            if (dgvc is TextBoxXCell)
                            {
                                tbxc = (TextBoxXCell)dgvc;
                                tbxc.ButtonCustom = value;
                            }
                        }
                    }
                }
            }
        }
    }
}
