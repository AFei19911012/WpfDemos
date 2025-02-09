using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtkWpfDemo
{
	///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2025 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2025/2/9 16:09:44
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2025/2/9 16:09:44                     BigWang         首次编写         
	///
    public class DataIoHelper
    {
        public static Data3DModel ReadDlt(string filename)
        {
            try
            {
                // 读取文件
                using BinaryReader reader = new(File.OpenRead(filename));
                int count = reader.ReadInt32();
                // 线宽
                int rowCount = reader.ReadInt32();
                int LineCount = rowCount;
                // 总点数
                int pointCount = reader.ReadInt32();
                float[] valueZ = new float[pointCount];
                double minZ = 0;
                double maxZ = 0;
                for (int i = 0; i < pointCount; i++)
                {
                    float val = reader.ReadSingle();
                    valueZ[i] = val;
                    if (val > maxZ)
                    {
                        maxZ = val;
                    }
                    if (val < minZ && val > -1000)
                    {
                        minZ = val;
                    }
                }

                double dW = 0;
                double dH = 0;
                float[] valueL = null;
                if (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    // 亮度图像 
                    int lightCount = reader.ReadInt32();
                    if (lightCount == valueZ.Length)
                    {
                        valueL = new float[lightCount];
                        for (int i = 0; i < lightCount; i++)
                        {
                            float val = reader.ReadSingle();
                            valueL[i] = val;
                        }
                        dW = reader.ReadDouble();
                        dH = reader.ReadDouble();
                    }
                    else
                    {
                        reader.BaseStream.Seek(-sizeof(int), SeekOrigin.Current);
                        dW = reader.ReadDouble();
                        dH = reader.ReadDouble();
                    }
                }

                double grayScale = 1;
                if (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int grayMax = reader.ReadInt32();
                    grayScale = 256.0 / (grayMax * 1.0);
                }
                reader.Close();

                int nW = valueZ.Length / rowCount;
                int nH = rowCount;
                if (dW < 1 || dH < 1)
                {
                    dW = nW * 0.01;
                    dH = nH * 0.01;
                }
                if (valueZ.Length < 10)
                {
                    return null;
                }

                float spaceX = Convert.ToSingle(dW / ((valueZ.Length * 1.0) / (rowCount * 1.0)));
                float spaceY = Convert.ToSingle(dH / (rowCount * 1.0));
                float startX = Convert.ToSingle(-(dW * 1.0) / (2 * 1.0));
                float startY = Convert.ToSingle(-(dH * 1.0) / (2 * 1.0));
                int colCount = valueZ.Length / rowCount;
                float fX = startX;
                float fY = -startY;
                //float minVal = Convert.ToSingle(minZ / 1.3);
                //float maxVal = Convert.ToSingle(maxZ * 1.3);
                float minVal = Convert.ToSingle(minZ);
                float maxVal = Convert.ToSingle(maxZ);

                Data3DModel model = new Data3DModel();
                int idx = 0;
                for (int i = 0; i < rowCount; i++)
                {
                    fX = startX;
                    for (int j = 0; j < colCount; j++)
                    {
                        int post = i + j * rowCount;
                        float value = valueZ[post];
                        if (value < minVal)
                        {
                            value = minVal;
                        }
                        if (value > maxVal)
                        {
                            value = maxVal;
                        }

                        model.Points.InsertPoint(idx, fX, fY, value);

                        fX += spaceX;
                        idx++;
                    }
                    fY -= spaceY;
                }
                model.Width = nW;
                model.Height = nH;
                model.MinZ = minVal;
                model.MaxZ = maxVal;
                return model;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}