// See https://aka.ms/new-console-template for more information
using IronXL;
using ReadingExcel.DbContextLayer;
using ReadingExcel.Entitiy;
using System.Data;
using System.Data.SqlClient;

var products = new List<Product>();

WorkBook wb = WorkBook.Load("D://sanpham.xlsx");
DataSet ds = wb.ToDataSet();//behave complete Excel file as DataSet
foreach (DataTable dt in ds.Tables)//behave Excel WorkSheet as DataTable. 
{
    int k = 1;

    foreach (DataRow row in dt.Rows)//corresponding Sheet's Rows
    {
        var product = new Product();

        if (k != 1)
        {

            for (int h = 0; h < dt.Columns.Count; h++)//Sheet columns of corresponding row
            {
                if (h == 0)
                {
                    product.Id = row[h].ToString();
                }

                if (h == 1)
                {
                    product.Code = row[h].ToString();
                }

                if (h == 2)
                {
                    product.Name = row[h].ToString();
                }
                if (h == 3)
                {
                    product.Price = decimal.Parse(row[h].ToString());
                }
                if (h == 4)
                {
                    product.CapitalPrice = decimal.Parse(row[h].ToString());
                }
                if (h == 5)
                {
                    product.HangHoa = row[h].ToString();
                }

                if (h == 6)
                {
                    product.NhomHang = row[h].ToString();
                }


                if (h == 7)
                {
                    product.UrlImage = row[h].ToString();
                }

            }

            products.Add(product);
        }



        k++;


    }
}


using (SqlConnection conn = new SqlConnection())
{
    conn.ConnectionString = @"Server=DESKTOP-40F80LR\SQLEXPRESS;Database=readingexcel;Trusted_Connection=True;Trustservercertificate=True;MultipleActiveResultSets=true;Encrypt=False;";
    conn.Open();

}

using (var _context = new AppDbContext())
{
    foreach (var item in products)
    {
        _context.Add(item);
    }

    await _context.SaveChangesAsync();
}

using (var _context = new AppDbContext())
{
    var product = _context.Products.ToList();

    for (int i = 0; i < product.Count; i++)
    {
        Console.WriteLine($"{i} {product[i].Id} {product[i].Code} {product[i].Name} {product[i].Price} {product[i].CapitalPrice} {product[i].HangHoa} {product[i].NhomHang} {product[i].UrlImage}");
    }

}






Console.ReadKey();

