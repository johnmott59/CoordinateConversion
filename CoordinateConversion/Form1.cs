using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YLScsDrawing;
using System.Windows;
using YLScsDrawing.Drawing3d;
using SharpDX;

namespace CoordinateConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //orientation
        int cameraX = 0, cameraY = 0, cameraZ = 0, cubeX = 0, cubeY = 0, cubeZ = 0;

        YLScsDrawing.Drawing3d.Cuboid cub = new YLScsDrawing.Drawing3d.Cuboid(150, 150, 150);
        YLScsDrawing.Drawing3d.Camera cam = new YLScsDrawing.Drawing3d.Camera();

        private void Form1_Load(object sender, EventArgs e)
        {
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(400, 240, 0);

            cam.Location = new YLScsDrawing.Drawing3d.Point3d(400, 240, -500);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            cub.Draw(e.Graphics, cam);
        }

        Point3d OriginLocal;

        Vector3d XAxisLocal;
        Vector3d YAxisLocal;
        Vector3d ZAxisLocal;

        /*
         * Create the transform needed to go from the local to world
         */
        Vector3d XAxisWorld = new Vector3d(1, 0, 0);
        Vector3d YAxisWorld = new Vector3d(0, 1, 0);
        Vector3d ZAxisWorld = new Vector3d(0, 0, 1);


        Matrix3x3 LocalToWorldTransform;
        Matrix3x3 WorldToLocalTransform;



        private void GetLocalAxis()
        {
            OriginLocal = cub.Point3dArray[0];
            XAxisLocal = new Vector3d(OriginLocal, cub.Point3dArray[1]);
            YAxisLocal = new Vector3d(OriginLocal, cub.Point3dArray[3]);
            ZAxisLocal = Vector3d.CrossProduct(XAxisLocal, YAxisLocal);

            XAxisLocal.Normalise();
            YAxisLocal.Normalise();
            ZAxisLocal.Normalise();

            Vector3d X1 = XAxisWorld;
            Vector3d X1Prime = XAxisLocal;

            Vector3d X2 = YAxisWorld;
            Vector3d X2Prime = YAxisLocal;

            Vector3d X3 = ZAxisWorld;
            Vector3d X3Prime = ZAxisLocal;


            LocalToWorldTransform = new Matrix3x3()
            {
                M11 = (float)Vector3d.DotProduct(X1, X1Prime),
                M12 = (float)Vector3d.DotProduct(X1, X2Prime),
                M13 = (float)Vector3d.DotProduct(X1, X3Prime),
                M21 = (float)Vector3d.DotProduct(X2, X1Prime),
                M22 = (float)Vector3d.DotProduct(X2, X2Prime),
                M23 = (float)Vector3d.DotProduct(X2, X3Prime),
                M31 = (float)Vector3d.DotProduct(X3, X1Prime),
                M32 = (float)Vector3d.DotProduct(X3, X2Prime),
                M33 = (float)Vector3d.DotProduct(X3, X3Prime),
            };


            WorldToLocalTransform = new Matrix3x3()
            {
                M11 = (float)Vector3d.DotProduct(X1Prime, X1),
                M12 = (float)Vector3d.DotProduct(X1Prime, X2),
                M13 = (float)Vector3d.DotProduct(X1Prime, X3),
                M21 = (float)Vector3d.DotProduct(X2Prime, X1),
                M22 = (float)Vector3d.DotProduct(X2Prime, X2),
                M23 = (float)Vector3d.DotProduct(X2Prime, X3),
                M31 = (float)Vector3d.DotProduct(X3Prime, X1),
                M32 = (float)Vector3d.DotProduct(X3Prime, X2),
                M33 = (float)Vector3d.DotProduct(X3Prime, X3),
            };

        }


        private void btnApplyTransform_Click(object sender, EventArgs e)
        {
            List<Point3d> PointList = new List<Point3d>();

            foreach (Point3d p in cub.Point3dArray)
            {
                Vector3 v = new Vector3() { X = (float)(p.X - OriginLocal.X), Y = (float)(p.Y - OriginLocal.Y), Z = (float)(p.Z - OriginLocal.Z) };

                v = Vector3.Transform(v, LocalToWorldTransform);

                PointList.Add(new Point3d() { X = v.X + OriginLocal.X, Y = v.Y + OriginLocal.Y, Z = v.Z + OriginLocal.Z });
            }

            cub.pts = PointList.ToArray();

            Invalidate();
        }

        private void btnReverseTransform_Click(object sender, EventArgs e)
        {
            List<Point3d> PointList = new List<Point3d>();

            foreach (Point3d p in cub.Point3dArray)
            {
                Vector3 v = new Vector3() { X = (float)(p.X - OriginLocal.X), Y = (float)(p.Y - OriginLocal.Y), Z = (float)(p.Z - OriginLocal.Z) };

                v = Vector3.Transform(v, WorldToLocalTransform);

                PointList.Add(new Point3d() { X = v.X + OriginLocal.X, Y = v.Y + OriginLocal.Y, Z = v.Z + OriginLocal.Z });
            }

            cub.pts = PointList.ToArray();

            Invalidate();
        }

        private void RotatePositiveX(object sender, EventArgs e)
        {
            cubeX += 5;
            labelCrX.Text = cubeX.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(1, 0, 0), 5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);

            GetLocalAxis();

            Invalidate();
        }

        private void RotateNegativeX(object sender, EventArgs e)
        {
            cubeX -= 5;
            labelCrX.Text = cubeX.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(1, 0, 0), -5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);

            GetLocalAxis();

            Invalidate();
        }

        private void RotatePositiveY(object sender, EventArgs e)
        {
            cubeY += 5;
            labelCrY.Text = cubeY.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(0, 1, 0), 5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);

            GetLocalAxis();

            Invalidate();
        }

        private void RotateNegativeY(object sender, EventArgs e)
        {
            cubeY -= 5;
            labelCrY.Text = cubeY.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(0, 1, 0), -5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);

            GetLocalAxis();

            Invalidate();
        }

        private void RotatePositiveZ(object sender, EventArgs e)
        {
            cubeZ += 5;
            labelCrZ.Text = cubeZ.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(0, 0, 1), 5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);

            GetLocalAxis();

            Invalidate();
        }


        private void RotateNegativeZ(object sender, EventArgs e)
        {
            cubeZ -= 5;
            labelCrZ.Text = cubeZ.ToString();
            YLScsDrawing.Drawing3d.Quaternion q = new YLScsDrawing.Drawing3d.Quaternion();
            q.FromAxisAngle(new YLScsDrawing.Drawing3d.Vector3d(0, 0, 1), -5 * Math.PI / 180.0);
            cub.RotateAt(cub.Center, q);

            GetLocalAxis();

            Invalidate();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cub = new YLScsDrawing.Drawing3d.Cuboid(150, 150, 150);
            cam = new YLScsDrawing.Drawing3d.Camera();
            cub.Center = new YLScsDrawing.Drawing3d.Point3d(400, 240, 0);
            cam.Location = new YLScsDrawing.Drawing3d.Point3d(400, 240, -500);
            Invalidate();
            i = 0;
            bmp = new Bitmap[6];
            labelCx.Text = cub.Center.X.ToString();
            labelCy.Text = cub.Center.Y.ToString();
            labelCz.Text = cub.Center.Z.ToString();
            cameraX = 0; cameraY = 0; cameraZ = 0; cubeX = 0; cubeY = 0; cubeZ = 0;
            labelCrX.Text = "0";
            labelCrY.Text = "0";
            labelCrZ.Text = "0";
        }

        Bitmap[] bmp = new Bitmap[6];
        int i = 0;
        private void button13_Click(object sender, EventArgs e)
        {
            if (i == 6) return;
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                bmp[i] = new Bitmap(o.FileName);
                i++;
            }
            cub.FaceImageArray = bmp;
            cub.DrawingLine = false;
            cub.DrawingImage = true;
            cub.FillingFace = true;
            Invalidate();
        }
 


    }
}
