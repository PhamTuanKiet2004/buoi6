//bai 19
/*Console.WriteLine("Nhap 1 ki tu: ");
string input = Console.ReadLine();
bool isCorrect = false;
input = input.ToLower().Trim();
switch (input)
{
    case "u": 
    isCorrect = true;
    break;
    case "e":
    isCorrect = true;
    break;
    case "o":
    isCorrect = true;
    break;
    case "a":
    isCorrect = true;
    break;
    case "i":
    isCorrect = true;
    break;
}

if (!isCorrect)
{
    Console.WriteLine("khong phai nguyen am");
}
else
{
    Console.WriteLine("La nguyen am");
}*/


// Bai 1: 

do
{
    Console.WriteLine("Nhap so dien: ");
    int soDien = int.Parse(Console.ReadLine());
    int total = 0;
    int bac1, bac2, bac3, bac4, bac5, bac6;
    if (soDien > 0 && soDien <= 50)
    {
        total = soDien * 1984;
    }

    else if (soDien >= 51 && soDien <= 100)
    {
        total = 50 * 1984 + (soDien - 50) * 2050;

    }
    else if (soDien >= 101 && soDien <= 200)
    {
        total = 50 * 1984 + 50 * 2050 + (soDien - 100) * 2380;
    }
    else if (soDien >= 201 && soDien <= 300)
    {
        total = 50 * 1984 + 50 * 2050 + 100 * 2380 + (soDien - 200) * 2998;
    }
    else if (soDien >= 301 && soDien <= 400)
    {
        total = 50 * 1984 + 50 * 2050 + 100 * 2380 + 100 * 2998 + (soDien - 300) * 3350;
       
    }
    else
    {
        total = 50 * 1984 + 50 * 2050 + 100 * 2380 + 100 * 2998 + 100 * 3350 + (soDien - 400) * 3460;
       
    }
    bac1 = Math.Min(soDien, 50) * 1984;
    bac2 = Math.Min(Math.Max(soDien - 50, 0), 50) * 2050;
    bac3 = Math.Min(Math.Max(soDien - 100, 0), 100) * 2380;
    bac4 = Math.Min(Math.Max(soDien - 200, 0), 100) * 2998;
    bac5 = Math.Min(Math.Max(soDien - 300, 0), 100) * 3350;
    bac6 = Math.Max(soDien - 400, 0) * 3460;
    Console.WriteLine("Tong dien truoc VAT: " + total);
    double vatTotal = total + (total * 0.08);
    Console.WriteLine(("Tien sau VAT: " + vatTotal));
    Console.WriteLine("Ban tieu het tong "+soDien+" so dien");

    if (bac1 > 0)
    {
        Console.WriteLine("So tien tieu o bac 1: " + bac1);
    }

    if (bac2 > 0)
    {
        Console.WriteLine("So tien tieu o bac 2: " + bac2);
    }

    if (bac3 > 0)
    {
        Console.WriteLine("So tien tieu o bac 3: " + bac3);
    }

    if (bac4 > 0)
    {
        Console.WriteLine("So tien tieu o bac 4: " + bac4);
    }

    if (bac5 > 0)
    {
        Console.WriteLine("So tien tieu o bac 5: " + bac5);
    }

    if (bac6 > 0)
    {
        Console.WriteLine("So tien tieu o bac 6: " + bac6);
    }
    
    
    Console.WriteLine("1: tinh tien tiep || 0: ket thuc chuong trinh");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a == 0)
    {
        break;
    }
} while (true);

//bai 2:
Console.Write("Nhap luong: ");
int luong = int.Parse(Console.ReadLine());
int chucVu;
int phuCap=0;
string[] name = ["NV", "Truong nhom", "Truong phong", "Giam doc"];
string name1="";
double luongGio = (double)luong / (22 * 8);
do
{
    Console.WriteLine("1: NV, 2: Trưởng nhóm, 3: Trưởng phòng, 4: Giám đốc ");
    chucVu = int.Parse(Console.ReadLine());
    if (chucVu <= 0 || chucVu > 4)
    {
        Console.WriteLine("Vui long nhap trong khoang tu 1 den 4");
    }

} while (chucVu <= 0 || chucVu > 4);
switch (chucVu)
{
    case 1: phuCap = 500000;
        name1 = name[0];
        break;
    case 2: phuCap = 2000000;
        name1 = name[1];
        break;
    case 3: phuCap = 5000000;
        name1 = name[2];
        break;
    case 4: phuCap = 12000000; 
        name1 = name[3];
        break;
}
Console.WriteLine("So nam tham nien: ");
int soNamThamNien = int.Parse(Console.ReadLine());
double phuCapThamNien = 0;
if (soNamThamNien < 3)
{
    phuCapThamNien = 0;
}
else if (soNamThamNien >= 3 && soNamThamNien <= 5)
{
    phuCapThamNien = luong*0.05;
}
else if (soNamThamNien >= 6 && soNamThamNien <= 10)
{
    phuCapThamNien = luong*0.1;
}
else
{
    phuCapThamNien = luong*0.18;
}
Console.WriteLine("So gio lam them: ");
int tgOT = int.Parse(Console.ReadLine());
double luongOT = 0;
if(tgOT <=40 && tgOT >0){luongOT = 1.5*luongGio*tgOT;}
else
{
    luongOT = 1.5 * luongGio*40 + (tgOT - 40) * 2*luongGio;
}

double bhxh = (luong + phuCap)*0.105;
double tncn = 0;
double tongThuNhap = luong + phuCapThamNien + luongOT + phuCap;
if (tongThuNhap < 10000000)
{
    tncn = 0;
}else if (tongThuNhap >= 10000000 && tongThuNhap < 20000000)
{
    tncn = tongThuNhap * 0.05;
}else if (tongThuNhap >= 20000000 && tongThuNhap <= 35000000)
{
    tncn = tongThuNhap * 0.1;
}
else
{
    tncn = tongThuNhap * 0.15;
}

Console.WriteLine("Luong co ban: "+luong);
Console.WriteLine("Chuc vu cua ban la: "+ name1);
Console.WriteLine("Phu cap chuc vu cua ban la: "+phuCap);
Console.WriteLine("Phu cap tham nien cua ban la: "+phuCapThamNien);
Console.WriteLine("Tien lam them gio cua ban la: "+luongOT);
Console.WriteLine("Tong thu nhap truoc khau tru: " + tongThuNhap);
Console.WriteLine("Khau tru BHXH + BHYT la: "+bhxh );
Console.WriteLine("Khau tru thue TNCN: "+ tncn);
double luongThucNhan = Math.Floor(tongThuNhap - bhxh - tncn);
Console.WriteLine("Luong thuc nhan cua ban: "+luongThucNhan);




