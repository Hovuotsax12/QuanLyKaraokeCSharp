﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KARAOKE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDonViTinh());
            //Application.Run(new frmMatHang());
            //Application.Run(new frmLoaiPhong());
            //Application.Run(new frmPhong());
            //Application.Run(new frmNhaCungCap());
            //Application.Run(new frmNhanVien());
            //Application.Run(new frmNhapHang());
            //Application.Run(new frmBanHang());
            Application.Run(new frmMain());
        }
    }
}