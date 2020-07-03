using System;
using System.Collections.Generic;
using System.ComponentModel1;
using System.data;
using System.Linq;
using System.Text
using System.windows.Forms;
using system.Drawing;
namespace Screen_Capture
{
    public partial class Form : Form
    {
    public form1()
    {
    InitializeComponnt();
    }
    private void Button_click(object sender,EventArgs e){
    SendKeys.Send("{PRTSC}");
    Image img = Clipboard.GetImage();
    pictureBox1.Image = img;
    img.Save("D:\\myimg.jpg");
    this.Show();
    }
    }
}
