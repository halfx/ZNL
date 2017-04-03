using System;
using System.Windows.Forms;

namespace ZNLCRM.Controls
{
    public class TextBoxXCell : DataGridViewTextBoxCell
    {
        private DataGridViewTriState includePrompt;
        private DataGridViewTriState includeLiterals;
        private Type validatingType;
        private DevComponents.Editors.InputButtonSettings buttonCustom;
        //=------------------------------------------------------------------=
        // TextBoxXCell
        //=------------------------------------------------------------------=
        /// <summary>
        ///   Initializes a new instance of this class.  Fortunately, there's
        ///   not much to do here except make sure that our base class is 
        ///   also initialized properly.
        /// </summary>
        /// 
        public TextBoxXCell()
            : base()
        {
            this.includePrompt = DataGridViewTriState.NotSet;
            this.includeLiterals = DataGridViewTriState.NotSet;
            this.validatingType = typeof(string);
        }
        ///   Whenever the user is to begin editing a cell of this type, the editing
        ///   control must be created, which in this column type's
        ///   case is a subclass of the TextBoxX control.
        /// 
        ///   This routine sets up all the properties and values
        ///   on this control before the editing begins.
        public override void InitializeEditingControl(int rowIndex,
                                                      object initialFormattedValue,
                                                      DataGridViewCellStyle dataGridViewCellStyle)
        {
            TextBoxXEditingControl tbxec;
            TextBoxXColumn tbxcol;
            DataGridViewColumn dgvc;
            
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                                          dataGridViewCellStyle);
            
            tbxec = DataGridView.EditingControl as TextBoxXEditingControl;
            tbxec.ButtonCustomClick += (this.OwningColumn as TextBoxXColumn).OnButtonCustomClick;
            //
            // set up props that are specific to the TextBoxX
            //

            dgvc = this.OwningColumn;   // this.DataGridView.Columns[this.ColumnIndex];
            if (dgvc is TextBoxXColumn)
            {
                tbxcol = dgvc as TextBoxXColumn;

                //
                // IncludePrompt
                //
                if (this.includePrompt == DataGridViewTriState.NotSet)
                {
                    //mtbec.IncludePrompt = mtbcol.IncludePrompt;
                }
                else
                {
                    //mtbec.IncludePrompt = BoolFromTri(this.includePrompt);
                }

                //
                // IncludeLiterals
                //
                if (this.includeLiterals == DataGridViewTriState.NotSet)
                {
                    //mtbec.IncludeLiterals = mtbcol.IncludeLiterals;
                }
                else
                {
                    //mtbec.IncludeLiterals = BoolFromTri(this.includeLiterals);
                }

                //
                // Finally, the validating type ...
                //
                if (this.ValidatingType == null)
                {
                    tbxec.ValidatingType = tbxcol.ValidatingType;
                }
                else
                {
                    tbxec.ValidatingType = this.ValidatingType;
                }

                if (this.ButtonCustom == null)
                {
                    tbxec.ButtonCustom.Checked = tbxcol.ButtonCustom.Checked;
                    tbxec.ButtonCustom.DisplayPosition = tbxcol.ButtonCustom.DisplayPosition;
                    tbxec.ButtonCustom.Enabled = tbxcol.ButtonCustom.Enabled;
                    tbxec.ButtonCustom.Image = tbxcol.ButtonCustom.Image;
                    //tbxec.ButtonCustom.ItemReference = tbxcol.ButtonCustom.ItemReference;
                    tbxec.ButtonCustom.Shortcut = tbxcol.ButtonCustom.Shortcut;
                    tbxec.ButtonCustom.Text = tbxcol.ButtonCustom.Text;
                    tbxec.ButtonCustom.Visible = tbxcol.ButtonCustom.Visible;
                }

                tbxec.Text = this.Value == DBNull.Value || this.Value == null ? "" : this.Value.ToString();
            }
        }

        public override void DetachEditingControl()
        {
            base.DetachEditingControl();
            TextBoxXEditingControl ctl = DataGridView.EditingControl as TextBoxXEditingControl;
            if (ctl != null)
            {
                ctl.ButtonCustomClick -= (this.OwningColumn as TextBoxXColumn).OnButtonCustomClick;
            }
        }
        //  Returns the type of the control that will be used for editing
        //  cells of this type.  This control must be a valid Windows Forms
        //  control and must implement IDataGridViewEditingControl.
        public override Type EditType
        {
            get
            {
                return typeof(TextBoxXEditingControl);
            }
        }

        //  A boolean indicating whether to include prompt characters in
        //  the Text property's value.
        public virtual DataGridViewTriState IncludePrompt
        {
            get
            {
                return this.includePrompt;
            }
            set
            {
                this.includePrompt = value;
            }
        }

        //  A boolean value indicating whether to include literal characters
        //  in the Text property's output value.
        public virtual DataGridViewTriState IncludeLiterals
        {
            get
            {
                return this.includeLiterals;
            }
            set
            {
                this.includeLiterals = value;
            }
        }

        //  A Type object for the validating type.
        public virtual Type ValidatingType
        {
            get
            {
                return this.validatingType;
            }
            set
            {
                this.validatingType = value;
            }
        }

        /// <summary>
        /// 第一个自定义按钮
        /// </summary>
        public virtual DevComponents.Editors.InputButtonSettings ButtonCustom
        {
            get
            {
                return this.buttonCustom;
            }
            set
            {
                this.buttonCustom = value;
            }
        }
        //   Quick routine to convert from DataGridViewTriState to boolean.
        //   True goes to true while False and NotSet go to false.
        protected static bool BoolFromTri(DataGridViewTriState tri)
        {
            return (tri == DataGridViewTriState.True) ? true : false;
        }

        //public override Type FormattedValueType
        //{
        //    get
        //    {
        //        return typeof(string);
        //    }
        //}
    }
}
