using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CustomForm : Form
{
    Panel toolBar = new Panel();
    EllipseButton minimizeButton = new EllipseButton();
    EllipseButton closeButton = new EllipseButton();
    Label titleLabel = new Label();
    PictureBox iconPic = new PictureBox();

    Color toolBarColor = Color.DarkGray;
    
    [Description("Potato"),Category("Toolbar")]
    public Color ToolBarColor
    {
        get
        {
            return toolBarColor;
        }
        set
        {
            toolBarColor = value;
        }
    }


    public CustomForm() {
        
    }

    protected override void OnLoad(EventArgs e)
    {
        this.FormBorderStyle = FormBorderStyle.None;
        

        toolBar.Location = new Point(0, 0);
        toolBar.Width = Width;
        toolBar.Height = 30;
        toolBar.BackColor = toolBarColor;
        toolBar.MouseDown += toolBar_MouseDown;
        this.Controls.Add(toolBar);

        titleLabel.Text = this.Text;
        if (ShowIcon)
            titleLabel.Location = new Point(50, 8);
        else
            titleLabel.Location = new Point(10, 8);
        toolBar.Controls.Add(titleLabel);

        minimizeButton.BackColor = Color.Green;
        minimizeButton.Width = 13;
        minimizeButton.Height = 13;
        minimizeButton.FlatStyle = FlatStyle.Flat;
        minimizeButton.FlatAppearance.BorderSize = 0;
        minimizeButton.Location = new Point(Width - 35, 8);
        minimizeButton.Click += MinimizeButton_Click; ;
        toolBar.Controls.Add(minimizeButton);
        
        closeButton.BackColor = Color.DarkRed;
        closeButton.Width = 13;
        closeButton.Height = 13;
        closeButton.FlatStyle = FlatStyle.Flat;
        closeButton.FlatAppearance.BorderSize = 0;
        closeButton.Location = new Point(this.Width - 20, 8);
        closeButton.Click += CloseButton_Click;
        toolBar.Controls.Add(closeButton);

        if (ShowIcon)
        {
            iconPic.Location = new Point(10,2);
            iconPic.Width = iconPic.Height = 25;
            iconPic.SizeMode = PictureBoxSizeMode.Zoom;
            iconPic.Image = this.Icon.ToBitmap();
            iconPic.DoubleClick += IconPic_DoubleClick;
            toolBar.Controls.Add(iconPic);
        }
        base.OnLoad(e);
    }

    private void IconPic_DoubleClick(object sender, EventArgs e)
    {
        this.Close();
    }

    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    private void toolBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }




    private void MinimizeButton_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}