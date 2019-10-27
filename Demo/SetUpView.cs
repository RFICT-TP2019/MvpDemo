using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace Demo
{
    public partial class SetUpView : Form, ISetUpView
    {
        private readonly ApplicationContext _context;
        public SetUpView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public string NumberOfFloors => tb_NumberOfFloors.Text;

        public event Action SetUp;

        public void ShowError(string message)
        {
            lbl_Error.Text = message;
        }

        private void btn_SetUp_Click(object sender, EventArgs e)
        {
            lbl_Error.Text = "";
            SetUp?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
