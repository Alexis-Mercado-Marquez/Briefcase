using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string path = Path.GetFileName(FileUpload1.FileName);
        path = path.Replace(" ", "");
        FileUpload1.SaveAs(Server.MapPath("~/ExcelFile/") + path);
        String ExcelPath = Server.MapPath("~/ExcelFile/") + path;
        OleDbConnection mycon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ExcelPath + "; Extended Properties=Excel 8.0; Persist Security Info = False");
        mycon.Open();
        OleDbCommand cmd = new OleDbCommand("select * from [Hoja1$]", mycon);
        OleDbDataAdapter da = new OleDbDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
        mycon.Close();
        Label3.Text = "¡El archivo ha sido guardado y capturado!";
    }
}