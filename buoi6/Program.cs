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


// bai 3:
Console.WriteLine("--- CHUONG TRINH TINH HOA DON BIGMART 2026 ---");

            Console.Write("Nhap tong tien mua hang chua giam gia (VND): ");
            double tongTienGoc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Chon loai thanh vien (1: Thuong, 2: Silver, 3: Gold, 4: Platinum): ");
            int loaiThanhVien = Convert.ToInt32(Console.ReadLine());

            Console.Write("Co su dung voucher khong? (Y/N): ");
            string coVoucher = Console.ReadLine().Trim().ToUpper();

            Console.Write("Nhap so diem tich luy hien co (nhap 0 neu khong co hoac khong dung): ");
            int diemTichLuy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Phuong thuc thanh toan (1: Tien mat, 2: Chuyen khoan/Vi dien tu): ");
            int phuongThucTT = Convert.ToInt32(Console.ReadLine());


            double phanTramGiam = 0;
            if (loaiThanhVien == 1)
            {
                if (tongTienGoc > 5000000) phanTramGiam = 5;
                else if (tongTienGoc > 2000000) phanTramGiam = 2;
                else phanTramGiam = 0;
            }
            else if (loaiThanhVien == 2) 
            {
                if (tongTienGoc > 5000000) phanTramGiam = 7;
                else if (tongTienGoc > 2000000) phanTramGiam = 4;
                else phanTramGiam = 3;
            }
            else if (loaiThanhVien == 3) 
            {
                if (tongTienGoc > 5000000) phanTramGiam = 10;
                else if (tongTienGoc > 2000000) phanTramGiam = 6;
                else phanTramGiam = 5;
            }
            else if (loaiThanhVien == 4) 
            {
                if (tongTienGoc > 5000000) phanTramGiam = 12;
                else if (tongTienGoc > 2000000) phanTramGiam = 7;
                else phanTramGiam = 8;
            }

            double tienGiamThanhVien = tongTienGoc * (phanTramGiam / 100);
            double tienSauGiamThanhVien = tongTienGoc - tienGiamThanhVien;


            double tienGiamVoucher = 0;
            if (coVoucher == "Y")
            {
                if (tienSauGiamThanhVien > 3000000)
                {
                    tienGiamVoucher = 3000000; 
                }
                else if (tienSauGiamThanhVien > 1000000)
                {
                    tienGiamVoucher = 100000;
                }
            }
            double tienSauVoucher = tienSauGiamThanhVien - tienGiamVoucher;


            double tienGiamDiem = 0;
            if (diemTichLuy >= 100)
            {

                int soDiemHopLe = (diemTichLuy / 100) * 100; 
                tienGiamDiem = soDiemHopLe * 100; 

                if (tienGiamDiem > tienSauVoucher)
                {
                    tienGiamDiem = tienSauVoucher; 
                }
            }
            double tienSauDiem = tienSauVoucher - tienGiamDiem;
            double tienGiamPTTT = 0;
            if (phuongThucTT == 2)
            {
                tienGiamPTTT = tienSauDiem * 0.005;
            }
            double tongTienThanhToan = tienSauDiem - tienGiamPTTT;


            tongTienThanhToan = Math.Round(tongTienThanhToan);

            int diemTichLuyMoi = (int)(tongTienThanhToan / 100000);

            // 6. In hóa đơn
            Console.WriteLine("\n============= HOA DON BIGMART =============");
            Console.WriteLine($"Tong tien hang goc:      {tongTienGoc:N0} d");
            Console.WriteLine($"Giam gia thanh vien ({phanTramGiam}%): -{tienGiamThanhVien:N0} d");
            Console.WriteLine($"Giam gia Voucher:        -{tienGiamVoucher:N0} d");
            Console.WriteLine($"Giam tu diem tich luy:   -{tienGiamDiem:N0} d");
            if (phuongThucTT == 2)
            {
                Console.WriteLine($"Giam Chuyen khoan (0.5%):-{tienGiamPTTT:N0} d");
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"TONG TIEN THANH TOAN:    {tongTienThanhToan:N0} d");
            Console.WriteLine($"Diem tich luy moi nhan:  +{diemTichLuyMoi} diem");
            Console.WriteLine("===========================================");


// bai 4:
while (true)
            {
                Console.WriteLine("--- CHUONG TRINH QUAN LY DAT PHONG KHACH SAN 2026 ---");
                Console.Write("Nhap so ngay o: ");
                int soNgayO = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Chon loai phong (1: Standard, 2: Deluxe, 3: Suite): ");
                int loaiPhong = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap so luong nguoi lon: ");
                int soNguoiLon = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap so luong tre em (duoi 12 tuoi): ");
                int soTreEm = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap so ngay roi vao cuoi tuan (Thu 6, Thu 7): ");
                int soNgayCuoiTuan = Convert.ToInt32(Console.ReadLine());
                double donGiaPhong = 0;
                if (loaiPhong == 1) donGiaPhong = 1200000;
                else if (loaiPhong == 2) donGiaPhong = 2500000;
                else if (loaiPhong == 3) donGiaPhong = 4800000;
                
                int soNgayThuong = soNgayO - soNgayCuoiTuan;
                if (soNgayThuong < 0) soNgayThuong = 0; 
                double tienPhongNgayThuong = soNgayThuong * donGiaPhong;
                double tienPhongCuoiTuan = soNgayCuoiTuan * (donGiaPhong * 1.2); 
                double tongTienPhongGoc = tienPhongNgayThuong + tienPhongCuoiTuan;
                double tienGiamNgayThu5 = 0;
                if (soNgayO >= 5)
                {
                    tienGiamNgayThu5 = tongTienPhongGoc * 0.10;
                }
                double tienPhongSauGiam = tongTienPhongGoc - tienGiamNgayThu5;
                double tienPhuThuTreEm = 0;
                if (soTreEm > 1)
                {
                    int soTrePhuThu = soTreEm - 1;
                    tienPhuThuTreEm = soTrePhuThu * (donGiaPhong * 0.3) * soNgayO;
                }
                double tienDichVu = 0;
                Console.Write("Su dung Buffet an sang? (Y/N): ");
                if (Console.ReadLine().Trim().ToUpper() == "Y")
                {
                    tienDichVu += (soNguoiLon + soTreEm) * 150000 * soNgayO;
                }
                Console.Write("Nhap so kg giat ui (Nhap 0 neu khong dung): ");
                double kgGiatUi = Convert.ToDouble(Console.ReadLine());
                tienDichVu += kgGiatUi * 80000;
                Console.Write("Nhap so luot xe dua don san bay (Nhap 0 neu khong dung): ");
                int soLuotXe = Convert.ToInt32(Console.ReadLine());
                tienDichVu += soLuotXe * 600000;
                Console.Write("Nhap so luot su dung Spa (Nhap 0 neu khong dung): ");
                int soLuotSpa = Convert.ToInt32(Console.ReadLine());
                tienDichVu += soLuotSpa * 1200000;
                double tongChiPhiTruocKM = tienPhongSauGiam + tienPhuThuTreEm + tienDichVu;
                double tienKhuyenMai = 0;
                if (soNgayO >= 7)
                {
                    tienKhuyenMai += tongChiPhiTruocKM * 0.05;
                }
                if (tongChiPhiTruocKM > 30000000)
                {
                    tienKhuyenMai += tongChiPhiTruocKM * 0.03;
                }
                double tienTruocThue = tongChiPhiTruocKM - tienKhuyenMai;
                double thueVAT = tienTruocThue * 0.10;
                double tongThanhToanCuoi = tienTruocThue + thueVAT;
                tongThanhToanCuoi = Math.Round(tongThanhToanCuoi);
                
                Console.WriteLine("\n============= HOA DON KHACH SAN =============");
                Console.WriteLine($"Tien phong goc ({soNgayO} ngay):   {tongTienPhongGoc:N0} d");
                if (tienGiamNgayThu5 > 0)
                {
                    Console.WriteLine($"Giam gia phong (O >= 5 ngay):  -{tienGiamNgayThu5:N0} d");
                }
                if (tienPhuThuTreEm > 0)
                {
                    Console.WriteLine($"Phu thu tre em (tu be thu 2):  +{tienPhuThuTreEm:N0} d");
                }
                Console.WriteLine($"Tong tien dich vu them:        +{tienDichVu:N0} d");
                if (tienKhuyenMai > 0)
                {
                    Console.WriteLine($"Khuyen mai giam them:         -{tienKhuyenMai:N0} d");
                }
                Console.WriteLine($"Thue VAT (10%):                +{thueVAT:N0} d");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"TONG TIEN THANH TOAN:          {tongThanhToanCuoi:N0} d");
                Console.WriteLine("=============================================");
                
                Console.Write("\nBan co muon tinh luot dat phong khac khong? (Y/N): ");
                string tiepTuc = Console.ReadLine().Trim().ToUpper();
                if (tiepTuc != "Y")
                {
                    break; 
                }
            }




