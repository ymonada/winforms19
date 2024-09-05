using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms19.Interfaces;

namespace WinForms19.Models
{
    public static class FileReaderWriter
    {
        public static List<Triangle> TriangleRead(string FileName)
        {
            var result = new List<Triangle>();
            try
            {
                string fileContent = File.ReadAllText(FileName);
                string formated = fileContent
                    .Replace("x1", "")
                    .Replace("x2", "")
                    .Replace("x3", "")
                    .Replace("y1", "")
                    .Replace("y2", "")
                    .Replace("y3", "");
                string cleanedContent = new string(formated.
                    Where(c => char.IsDigit(c) || char.IsWhiteSpace(c))
                    .ToArray());
                string[] lines = cleanedContent
                    .Split(new[] { '\n', '\r','\t' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lines.Length; i += 4)
                {

                    string[] parts1 = lines[i + 1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string[] parts2 = lines[i + 2].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string[] parts3 = lines[i + 3].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    result.Add(
                       new Triangle(
                           new Point(int.Parse(parts1[0]), (int.Parse(parts1[1])))
                           , new Point(int.Parse(parts2[0]), (int.Parse(parts2[1])))
                           , new Point(int.Parse(parts3[0]), (int.Parse(parts3[1])))
                           , Color.Black
                        )
                       );
                }
                return result;
            }
            catch
            {
                return null;
            }

        }
        public static bool Write(IEnumerable<IFigure> result, string filename)
        {
            try
            {
                string StringResult = string.Empty;
                foreach (var figure in result)
                {
                    StringResult += figure.ToString();
                }
                File.WriteAllText(filename, StringResult);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool WriteText(string result, string filename)
        {
            try
            {  
                File.WriteAllText(filename, result);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<Rectangle> RectangleRead(string FileName)
        {
            var result = new List<Rectangle>();
            try
            {
                string fileContent = File.ReadAllText(FileName);
                string formated = fileContent
                    .Replace("x1", "")
                    .Replace("x2", "")
                    .Replace("x3", "")
                    .Replace("y1", "")
                    .Replace("y2", "")
                    .Replace("y3", "")
                    .Replace("x4", "")
                    .Replace("y4", "");
                string cleanedContent = new string(formated.
                    Where(c => char.IsDigit(c) || char.IsWhiteSpace(c))
                    .ToArray());
                string[] lines = cleanedContent
                    .Split(new[] { '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lines.Length; i += 5)
                {

                    string[] parts1 = lines[i + 1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string[] parts2 = lines[i + 2].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string[] parts3 = lines[i + 3].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string[] parts4 = lines[i + 4].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    result.Add(
                       new Rectangle(
                           new Point(int.Parse(parts1[0]), (int.Parse(parts1[1])))
                           , new Point(int.Parse(parts2[0]), (int.Parse(parts2[1])))
                           , new Point(int.Parse(parts3[0]), (int.Parse(parts3[1])))
                            , new Point(int.Parse(parts4[0]), (int.Parse(parts4[1])))
                           , Color.Black
                        )
                       );
                }
                return result;
            }
            catch
            {
                return null;
            }

        }
        public static string ReadText(string filename)
        {
            try
            {
               
                string fileContent = File.ReadAllText(filename);
                return fileContent;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
       
    }
}
