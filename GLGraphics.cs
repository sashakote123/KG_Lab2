using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    internal class GLGraphics
    {

        Vector3 cameraPositon = new Vector3(2, 3, 4);
        Vector3 cameraDirection = new Vector3(0, 0, 0);
        Vector3 cameraUp = new Vector3(0, 0, 1);

        public float latitude = 47.98f;
        public float longitude = 60.41f;
        public float radius = 5.385f;

        public float rotateAngle;

        public List<int> texturesIDs = new List<int>();

        public void Resize(int width, int height)
        {
            GL.ClearColor(Color.Black);
            GL.ShadeModel(ShadingModel.Smooth);
            GL.Enable(EnableCap.DepthTest);

            Matrix4 perspectiveMat = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.PiOver4,
                width / (float)height,
                1,
                64);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspectiveMat);
        }

        public void Update()
        {
            rotateAngle += 0.1f;
            cameraPositon = new Vector3(
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));



            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPositon, cameraDirection, cameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);
            
            SetupLighting();
            Render();
        }

        public void Update2()
        {
            cameraPositon = new Vector3(
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));


            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPositon, cameraDirection, cameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);

            SetupLighting();
            Render2();
        }

        public void Update3()
        {
            rotateAngle += 0.1f;
            cameraPositon = new Vector3(
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPositon, cameraDirection, cameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);

            SetupLighting();
            Render3();
        }
        
        public void Update4()
        {
            rotateAngle += 0.1f;
            cameraPositon = new Vector3(
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPositon, cameraDirection, cameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);

            SetupLighting();
            Render4();
        }

        public void Update5()
        {
            rotateAngle += 0.1f;
            cameraPositon = new Vector3(
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPositon, cameraDirection, cameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);

            SetupLighting();
            Render5();
        }

        public void Update6()
        {
            rotateAngle += 0.1f;
            cameraPositon = new Vector3(
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPositon, cameraDirection, cameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);

            SetupLighting();
            drawTriangle();
        }

        public void Update7()
        {
            rotateAngle += 0.1f;
            cameraPositon = new Vector3(
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPositon, cameraDirection, cameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);

            SetupLighting();
            drawTriangleStrip();
        }

        public void Update8()
        {
            rotateAngle += 0.1f;
            cameraPositon = new Vector3(
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPositon, cameraDirection, cameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);

            SetupLighting();
            drawTriangleFan();
        }

        public void Update9()
        {
            rotateAngle += 0.1f;
            cameraPositon = new Vector3(
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
     (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPositon, cameraDirection, cameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);

            SetupLighting();
            DrawCube();
        }

        private void drawTestQuad()
        {

            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texturesIDs[1]);
 
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.Red);
            GL.TexCoord2(0.0, 0.0);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Color3(Color.Blue);
            GL.TexCoord2(0.0, 1.0);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Color3(Color.White);
            GL.TexCoord2(1.0, 1.0);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Color3(Color.Green);
            GL.TexCoord2(1.0, 0.0);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
        }


        private void DrawTexturedQuad()
        {

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.Blue);
            GL.TexCoord2(0.0, 0.0);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Color3(Color.Red);
            GL.TexCoord2(0.0, 1.0);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Color3(Color.White);
            GL.TexCoord2(1.0, 1.0);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Color3(Color.Green);
            GL.TexCoord2(1.0, 0.0);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
        }

        private void DrawSphere(double r, int nx, int ny)
        {
            int ix, iy;
            double x, y, z;
            for (iy = 0; iy < ny; ++iy)
            {
                GL.Begin(BeginMode.QuadStrip);
                for (ix = 0; ix <= nx; ++ix)
                {
                    x = r * Math.Sin(iy * Math.PI / ny) * Math.Cos(2 * ix * Math.PI / nx);
                    y = r * Math.Sin(iy * Math.PI / ny) * Math.Sin(2 * ix * Math.PI / nx);
                    z = r * Math.Cos(iy * Math.PI / ny);
                    GL.Normal3(x, y, z);
                    GL.Vertex3(x, y, z);

                    x = r * Math.Sin((iy + 1) * Math.PI / ny) * Math.Cos(2 * ix * Math.PI / nx);
                    y = r * Math.Sin((iy + 1) * Math.PI / ny) * Math.Sin(2 * ix * Math.PI / nx);
                    z = r * Math.Cos((iy + 1) * Math.PI / ny);
                    GL.Normal3(x, y, z);
                    GL.Vertex3(x, y, z);
                }
                GL.End();
            }
        }



        private void drawTexturedQuad()
        {
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texturesIDs[0]);
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.Blue);
            GL.TexCoord2(0.0, 0.0);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Color3(Color.Red);
            GL.TexCoord2(0.0, 1.0);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Color3(Color.White);
            GL.TexCoord2(1.0, 1.0);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Color3(Color.Green);
            GL.TexCoord2(1.0, 0.0);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
        }

        private void drawPoint()
        {
            Random rndX = new Random();
            Random rndY = new Random();
            Random rndZ = new Random();
            GL.Begin(PrimitiveType.Points);
            for (int i = 0; i<500; i++)
                GL.Vertex3(rndX.Next(-5,5), rndY.Next(-5,5), rndY.Next(-5, 5));
            GL.Color3(Color.Green);
            GL.End();
        }

        private void drawLine()
        {



            int[] coordenates1 = new int[] { 1, 2, -3, -3, 3, 3, -1, -3, 2, 3, 1, 0, -2, 0, -4, 2, 1, 3, -1, -2, -3, 2, 0, -1, 3, -4, 2, 2, -4, 0};
            int[] coordenates2 = new int[] { -3, 1, -1, -1, 3, -1, 1, -2, 1, -5, -4, 1, 2, -5, 1, -2, -4, 0, 1, 1, -4, -3, 1, -1, 4, -2, -1, -4, -5, -3};
            int[] coordenates3 = new int[] { -4, -5, 4, -4, 4, -5, 2, -4, 2, 4, 3, 0, -2, -1, -5, -1, 4, 2, 2, -5, 3, -4, 4, 2, 3, 1, 3, -4, -3, -4};

            GL.Begin(PrimitiveType.Lines);
            for (int i = 0; i < 30; i++)
            {
                GL.Vertex3(coordenates1[i], coordenates2[i], coordenates3[i]);
                GL.Color3(Color.Green);
                GL.Vertex3(coordenates2[i], coordenates3[i], coordenates1[i]);
                GL.Color3(Color.Red);
                GL.Vertex3(coordenates3[i], coordenates1[i], coordenates2[i]);
                GL.Color3(Color.White);
                GL.Vertex3(coordenates2[i], coordenates3[i], coordenates2[i]);
                GL.Color3(Color.Blue);
                GL.Vertex3(coordenates3[i], coordenates3[i], coordenates2[i]);
                GL.Color3(Color.Purple);
                GL.Vertex3(coordenates2[i], coordenates3[i], coordenates2[i]);
                GL.Color3(Color.Brown);
            }


                GL.Color3(Color.Green);
            GL.End();
        }

        private void drawTriangle()
        {
            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex3(0,0,0);
            GL.Color3(Color.White);
            GL.Vertex3(0,1,1);
            GL.Color3(Color.Blue);
            GL.Vertex3(2,1,2);
            GL.Color3(Color.Red);

            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex3(1, 1, 2);
            GL.Color3(Color.Green);
            GL.Vertex3(3, 2, 3);
            GL.Color3(Color.Red);
            GL.Vertex3(2, 3, 2);
            GL.Color3(Color.Blue);

            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex3(4, 3, 5);
            GL.Color3(Color.Yellow);
            GL.Vertex3(2, 3, 5);
            GL.Color3(Color.Black);
            GL.Vertex3(5, 3, 4);
            GL.Color3(Color.White);

            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex3(-4, -3, -5);
            GL.Color3(Color.Green);
            GL.Vertex3(-2, -3, -5);
            GL.Color3(Color.Red);
            GL.Vertex3(-5, -3, -4);
            GL.Color3(Color.Yellow);

            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex3(-1, -1, -2);
            GL.Color3(Color.White);
            GL.Vertex3(-3, -2, -3);
            GL.Color3(Color.Green);
            GL.Vertex3(-2, -3, -2);
            GL.Color3(Color.Red);

            GL.End();


        }

        private void drawTriangleStrip()
        {
            GL.Begin(PrimitiveType.TriangleStrip);       
            GL.Vertex3(1, 0, 0);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(1, 1, 0);
            GL.Vertex3(0, 1, 0);
            GL.Color3(Color.Red);

            GL.Vertex3(0.5f, 0.5f, 1);
            GL.Vertex3(0, 0, 0);
            GL.Color3(Color.Purple);
            GL.Vertex3(1, 0, 0);
            GL.Color3(Color.Blue);
            GL.Vertex3(0.5f, 0.5f, 1);
            GL.Vertex3(1, 1, 0);
            GL.Color3(Color.Green);
            GL.End();

        }

        private void drawTriangleFan()
        {
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, texturesIDs[2]);


            GL.Begin(PrimitiveType.TriangleFan);
            GL.Vertex3(0, 0, 0.7f);
            for (int i = 0; i < 18; i++)
            {
                double angle = 2 * Math.PI * i / 17;
                double x = Math.Cos(angle);
                double y = Math.Sin(angle);

                GL.Vertex3(x, y, 0);
                GL.TexCoord3(x, y, 0);
            }



            GL.Color3(Color.FromArgb(237, 145, 47));
            GL.End();
            GL.Disable(EnableCap.Texture2D);
        }

        private void DrawCube()
        {

            GL.Begin(PrimitiveType.TriangleStrip);
            GL.Vertex3(1, 0, 0);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(1, 1, 0);
            GL.Vertex3(0, 1, 0);
            GL.Color3(Color.Red);
            GL.Vertex3(0, 1, 1);
            GL.Vertex3(0, 0, 1);
            GL.Vertex3(1, 1, 1);
            GL.Color3(Color.Green);


            GL.End();

            
        }


        public void Render()
        {

            drawTexturedQuad();

        
            drawTestQuad();
            GL.PushMatrix();
            GL.Translate(1, 1, 1);
            GL.Rotate(rotateAngle, Vector3.UnitZ);
            GL.Scale(0.5f, 0.5f, 0.5f);
            drawTestQuad();
            GL.PopMatrix();


            GL.Color3(Color.Green);
            DrawSphere(1.0f, 20, 20);



        }

        public void Render2()
        {
            drawTexturedQuad();
        }

        public void Render3()
        {

            GL.PushMatrix();
            //GL.Translate(1, 1, 1);
            GL.Translate(0, 0, 0);
            GL.Rotate(rotateAngle, Vector3.UnitZ);
            GL.Scale(1,1,1);
            drawTestQuad();
            GL.PopMatrix();

        }

        public void Render4()
        {
            drawPoint();
        }

        public void Render5()
        {
            drawLine();
        }

        public void Render6()
        {
            drawTriangle();
        }

        public int LoadTexture(String filePath)
        {
            try
            {
                Bitmap image = new Bitmap(filePath);
                int texID = GL.GenTexture();
                GL.BindTexture(TextureTarget.Texture2D, texID);
                BitmapData data = image.LockBits(
                    new System.Drawing.Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                GL.TexImage2D(TextureTarget.Texture2D, 0,
                    PixelInternalFormat.Rgba, data.Width, data.Height, 0,
                    OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
                image.UnlockBits(data);
                GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);
                return texID;
            }
            catch (System.IO.FileNotFoundException е)
            {
                return -1;
            }
        }


        public void SetupLighting()
        {
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.ColorMaterial);

            Vector4 lightingPosition = new Vector4(1.0f, 1.0f, 3.0f, 0.0f);
            GL.Light(LightName.Light0, LightParameter.Position, lightingPosition);

            Vector4 ambientColor = new Vector4(0.2f, 0.2f, 0.2f, 1.0f);
            GL.Light(LightName.Light0, LightParameter.Ambient, ambientColor);

            Vector4 diffuseColor = new Vector4(0.6f, 0.6f, 0.6f, 1.0f);
            GL.Light(LightName.Light0, LightParameter.Diffuse, diffuseColor);

            Vector4 materialSpecular = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, materialSpecular);

            float materialShininess = 100;
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, materialShininess);



        }


    }
}
