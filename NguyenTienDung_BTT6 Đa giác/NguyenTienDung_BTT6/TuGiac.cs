﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTienDung_BTT6
{
    internal class TuGiac:DaGiac
    {
        public double chu_vi = 0;
        public double TinhChuVi()
        {
            Canh c1 = new Canh(TapDinh[0], TapDinh[1]);
            Canh c2 = new Canh(TapDinh[1], TapDinh[2]);
            Canh c3 = new Canh(TapDinh[2], TapDinh[3]);
            Canh c4 = new Canh(TapDinh[3], TapDinh[0]);
            return c1.DoDai + c2.DoDai + c3.DoDai + c4.DoDai;
        }
        public double TinhDienTich()
        {
            Diem A = TapDinh[0];
            Diem B = TapDinh[1];
            Diem C = TapDinh[2];
            Diem D = TapDinh[3];
            Vector3D AB = B - A;
            Vector3D AC = C - A;
            Vector3D AD = D - A;
            return 0.5 * Vector3D.Cross(AB, AC).Norm + 0.5 * Vector3D.Cross(AC, AD).Norm;
        }
    }
}
