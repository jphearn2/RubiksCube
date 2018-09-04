using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubiksSolver
{
    public partial class MainMenu : Form
    {
        public string[,,] cube;
        public MainMenu(string[,,] cubeIn)
        {
            InitializeComponent();
            cube = cubeIn;
            LoadCube();
        }

        private void start_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("message");
            LoadCube();
        }

        private void LoadCube() // loads in the cube by taking in the text from inputs
                                // will possibly change to color input at later date
        {
            cube[0, 0, 0] = in000.Text;
            cube[0, 0, 1] = in001.Text;
            cube[0, 0, 2] = in002.Text;
            cube[0, 1, 0] = in010.Text;
            cube[0, 1, 1] = in011.Text;
            cube[0, 1, 2] = in012.Text;
            cube[0, 2, 0] = in020.Text;
            cube[0, 2, 1] = in021.Text;
            cube[0, 2, 2] = in022.Text;

            cube[1, 0, 0] = in100.Text;
            cube[1, 0, 1] = in101.Text;
            cube[1, 0, 2] = in102.Text;
            cube[1, 1, 0] = in110.Text;
            cube[1, 1, 1] = in111.Text;
            cube[1, 1, 2] = in112.Text;
            cube[1, 2, 0] = in120.Text;
            cube[1, 2, 1] = in121.Text;
            cube[1, 2, 2] = in122.Text;

            cube[2, 0, 0] = in200.Text;
            cube[2, 0, 1] = in201.Text;
            cube[2, 0, 2] = in202.Text;
            cube[2, 1, 0] = in210.Text;
            cube[2, 1, 1] = in211.Text;
            cube[2, 1, 2] = in212.Text;
            cube[2, 2, 0] = in220.Text;
            cube[2, 2, 1] = in221.Text;
            cube[2, 2, 2] = in222.Text;

            cube[3, 0, 0] = in300.Text;
            cube[3, 0, 1] = in301.Text;
            cube[3, 0, 2] = in302.Text;
            cube[3, 1, 0] = in310.Text;
            cube[3, 1, 1] = in311.Text;
            cube[3, 1, 2] = in312.Text;
            cube[3, 2, 0] = in320.Text;
            cube[3, 2, 1] = in321.Text;
            cube[3, 2, 2] = in322.Text;

            cube[4, 0, 0] = in400.Text;
            cube[4, 0, 1] = in401.Text;
            cube[4, 0, 2] = in402.Text;
            cube[4, 1, 0] = in410.Text;
            cube[4, 1, 1] = in411.Text;
            cube[4, 1, 2] = in412.Text;
            cube[4, 2, 0] = in420.Text;
            cube[4, 2, 1] = in421.Text;
            cube[4, 2, 2] = in422.Text;

            cube[5, 0, 0] = in500.Text;
            cube[5, 0, 1] = in501.Text;
            cube[5, 0, 2] = in502.Text;
            cube[5, 1, 0] = in510.Text;
            cube[5, 1, 1] = in511.Text;
            cube[5, 1, 2] = in512.Text;
            cube[5, 2, 0] = in520.Text;
            cube[5, 2, 1] = in521.Text;
            cube[5, 2, 2] = in522.Text;
        }

        private void UpdateCube()
        {
            in000.Text = cube[0, 0, 0];
            in000.Text = cube[0, 0, 1];
            in000.Text = cube[0, 0, 2];
            in000.Text = cube[0, 1, 0];
            in000.Text = cube[0, 1, 1];
            in000.Text = cube[0, 1, 2];
            in000.Text = cube[0, 2, 0];
            in000.Text = cube[0, 2, 1];
            in000.Text = cube[0, 2, 2];

            in100.Text = cube[1, 0, 0];
            in100.Text = cube[1, 0, 1];
            in100.Text = cube[1, 0, 2];
            in100.Text = cube[1, 1, 0];
            in100.Text = cube[1, 1, 1];
            in100.Text = cube[1, 1, 2];
            in100.Text = cube[1, 2, 0];
            in100.Text = cube[1, 2, 1];
            in100.Text = cube[1, 2, 2];
        
            in200.Text = cube[2, 0, 0];
            in200.Text = cube[2, 0, 1];
            in200.Text = cube[2, 0, 2];
            in200.Text = cube[2, 1, 0];
            in200.Text = cube[2, 1, 1];
            in200.Text = cube[2, 1, 2];
            in200.Text = cube[2, 2, 0];
            in200.Text = cube[2, 2, 1];
            in200.Text = cube[2, 2, 2];

            in300.Text = cube[3, 0, 0];
            in300.Text = cube[3, 0, 1];
            in300.Text = cube[3, 0, 2];
            in300.Text = cube[3, 1, 0];
            in300.Text = cube[3, 1, 1];
            in300.Text = cube[3, 1, 2];
            in300.Text = cube[3, 2, 0];
            in300.Text = cube[3, 2, 1];
            in300.Text = cube[3, 2, 2];
        
            in400.Text = cube[4, 0, 0];
            in400.Text = cube[4, 0, 1];
            in400.Text = cube[4, 0, 2];
            in400.Text = cube[4, 1, 0];
            in400.Text = cube[4, 1, 1];
            in400.Text = cube[4, 1, 2];
            in400.Text = cube[4, 2, 0];
            in400.Text = cube[4, 2, 1];
            in400.Text = cube[4, 2, 2];
        
            in500.Text = cube[5, 0, 0];
            in500.Text = cube[5, 0, 1];
            in500.Text = cube[5, 0, 2];
            in500.Text = cube[5, 1, 0];
            in500.Text = cube[5, 1, 1];
            in500.Text = cube[5, 1, 2];
            in500.Text = cube[5, 2, 0];
            in500.Text = cube[5, 2, 1];
            in500.Text = cube[5, 2, 2];
        }

        
    }
}
