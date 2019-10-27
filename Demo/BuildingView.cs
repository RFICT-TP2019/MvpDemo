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
    public partial class BuildingView : Form, IBuildingView
    {
        private readonly ApplicationContext _context;
        public BuildingView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void SetNumberOfFloors(int n)
        {
            lbl_Status.Text = "Total floors: " + n.ToString();
            SetActiveFloor(1);
            this.gb_Floors.Controls.Clear();
            for (int i = 0; i < n; ++i)
            {
                Button btn = new Button();
                btn.Size = new Size(80, 40);
                btn.Location = new Point(30, 30 + 50 * i);
                var floor = i + 1;
                btn.Text = "Floor №" + floor;
                btn.Click += (e, m) => CallElevator?.Invoke(floor);
                this.gb_Floors.Controls.Add(btn);
            }
        }

        public void SetActiveFloor(int floor)
        {
            lbl_numberOfFloors.Text = "Active floor: " + floor;
        }

        public event Action SetUp;
        public event Delegates.CallElevator CallElevator;

        private void btn_SetUp_Click(object sender, EventArgs e)
        {
            SetUp?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
