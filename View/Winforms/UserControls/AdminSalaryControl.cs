using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGEN.View.Winforms.UserControls
{
    public partial class AdminSalaryControl : UserControl
    {
        public AdminSalaryControl()
        {
            InitializeComponent();
            
            // Centrar texto de los RichTextBox
            FullNameBox.SelectAll();
            FullNameBox.SelectionAlignment = HorizontalAlignment.Center;

            CIBox.SelectAll();
            CIBox.SelectionAlignment = HorizontalAlignment.Center;

            PositionBox.SelectAll();
            PositionBox.SelectionAlignment = HorizontalAlignment.Center;

            ShiftBox.SelectAll();
            ShiftBox.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
