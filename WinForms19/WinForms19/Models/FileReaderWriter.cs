using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WinForms19.Interfaces;

namespace WinForms19.Models
{
    public static class FileReaderWriter
    {
        private static string FullPath(string path) => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
        private static List<Point> ReadPoints(string path)
        {
            var points = new List<Point>();
            string content = string.Empty;
            try
            {
                content = File.ReadAllText(FullPath(path));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error to Read {ex}");
            }
            foreach (Match match in Regex.Matches(content, @"(\d+); (\d+)"))
            {
                string point = match.Value;
                points.Add(new Point(
                    int.Parse(match.Groups[1].Value)
                    , int.Parse(match.Groups[2].Value))
                );
            }
            return points;
        }
        public static List<Triangle> TriangleRead(string FileName)
        {
            var result = new List<Triangle>();
            var points = ReadPoints(FileName);
            if (points.Count > 2 && points.Count % 3 == 0)
            {
                for (int i = 0; i < points.Count; i += 3)
                {
                    result.Add(
                        new Triangle(
                            points[i]
                            , points[i + 1]
                            , points[i + 2]
                            , Color.FromArgb(1, 235, 219, 178)));
                }
                return result;
            }
            return [];          
        }
        public static List<Rectangle> RectangleRead(string FileName)
        {
            var result = new List<Rectangle>();
            var points = ReadPoints(FileName);           
            if (points.Count > 3 && points.Count % 4 == 0)
            {
                for (int i = 0; i < points.Count; i += 4)
                {
                    result.Add(
                        new Rectangle(
                            points[i]
                            , points[i + 1]
                            , points[i + 2]
                             , points[i + 3]
                            , Color.Black));
                }
                return result;
            }
            return [];
        }
        public static void Write(IEnumerable<IFigure> result, string filename)
        {
            string StringResult = string.Empty;
            foreach (var figure in result)
            {
                StringResult += figure.ToString();
            }
            try
            {                
                File.WriteAllText(FullPath(filename), StringResult);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error  {e}");
            }
        }
        public static void WriteText(string result, string filename)
        {
            try
            {  
                File.WriteAllText(FullPath(filename), result);

            }
            catch(Exception e) 
            {
                MessageBox.Show($"Error {e}");
            }
        }      
        public static string ReadText(string filename)
        {
            try
            {              
                string fileContent = File.ReadAllText(FullPath(filename));
                return fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
                return string.Empty;
            }
        }
       
    }
}
