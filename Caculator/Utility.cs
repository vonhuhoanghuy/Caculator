using System.Windows.Forms;
namespace Tinhtoan
{ class Utility
    {
        public static string CheckDecimal(Control obj)
        {
            decimal t;
            if (obj.Text == "")
                return "Bạn chưa nhập vào ô " + obj.Tag + "?";
            else
                if (!decimal.TryParse(obj.Text, out t))
            {
                return "Dữ liệu " + obj.Text + " trong ô " + obj.Tag+ " không phải là số?";
            }
            else
                return "decimal";

        }
    }
}


