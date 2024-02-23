using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class dddd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code khoi tao du lieu cho cac dieu khien
            if (!Page.IsPostBack)
            {
                //khoi tao cho ddlTrinhDo
                ddlTrinhDo.Items.Add(new ListItem("Trung cấp"));
                ddlTrinhDo.Items.Add(new ListItem("Cao đẳng"));
                //...

                //khoi tao cho lstNgheNghiep
                lstNgheNghiep.Items.Add(new ListItem("Công nhân"));
                lstNgheNghiep.Items.Add(new ListItem("Lập trình viên"));
                lstNgheNghiep.Items.Add(new ListItem("Kỹ sư"));
                //...
                

                //khoi tao cho chkListSoThich
                chkListSoThich.Items.Add(new ListItem("Mua sắm"));
                chkListSoThich.Items.Add(new ListItem("Xem phim"));
                chkListSoThich.Items.Add(new ListItem("Du lịch"));
                chkListSoThich.Items.Add(new ListItem("Ăn nhậu"));
                int count = chkListSoThich.Items.Count;
              
                ///...
            }
        }

        protected void btGui_Click(object sender, EventArgs e)
        {
            string kq = "";
            kq += "<h2>Thông tin đăng ký của bạn</h2>";
            kq += "<ul>";
            //Lấy thông tin
            kq += $"<li>Họ Tên {txtHoTen.Text}</li>";

            kq += $"<li>Ngày Sinh {txtNgaySinh.Text}</li>";

            if (rdNam.Checked)
            {
                kq += $"<li>Giới Tính {rdNam.Text}</li>";
            }
            else
            {
                kq += $"<li>Giới Tính {rdNu.Text}</li>";
            }

            kq += $"<li>Trình Độ {ddlTrinhDo.SelectedItem.Text}</li>";

            kq += $"<li>Nghề Nghiệp {lstNgheNghiep.SelectedItem.Text}</li>";

            if (FHinh.HasFile)
            {
                string path = Server.MapPath("~/Uploads");
                FHinh.SaveAs(path + "/" + FHinh.FileName);

                lblhinhanh.Text += $"<li>Hình: <img src='Uploads/{FHinh.FileName}'> <li>";
            }

              
            string sothich = "";
            int i = 0;
           
          
            foreach(ListItem x in chkListSoThich.Items)
            {
                i++;
                if (x.Selected)
                {
                    sothich += "<br>+"+i+" "  + x.Text ;
                }
            }
            kq += $"<li>Sở Thích: {sothich}</li>";
            kq += "</ul>";
          

            lbKetQua.Text = kq;

        }
    }
}