using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.IO;

namespace AdminLTE.ViewComponents
{
    public class ControlSidebarViewComponent : ViewComponent
    {

        public ControlSidebarViewComponent()
        {
        }

        public IViewComponentResult Invoke(string filter)
        {
            if (string.IsNullOrEmpty(ViewBag.PageHelpFileName))
            {
                return View(string.Empty);
            }

            ViewBag.PageHelpContainer = LoadData(ViewBag.PageHelpFileName);
            return View();
        }

        private string LoadData(string filepath)
        {
            var basePath = Directory.GetCurrentDirectory() + @"\wwwroot\files\";
            var baseExtension = @".html";
            var absoluteFilePath = basePath + filepath + baseExtension;

            string result = string.Empty;
            try
            {
                if (!File.Exists(absoluteFilePath))
                {
                    return string.Empty;
                }

                using (StreamReader sr = new StreamReader(new FileStream(absoluteFilePath, FileMode.Open, FileAccess.Read)))
                {
                    result = sr.ReadToEnd();
                }
            }
            catch (FileNotFoundException fex)
            {
                Debug.Write(fex);
                return string.Empty;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                return string.Empty;
            }

            return result;
        }

        //private List<string> LoadData(string filename)
        //{
        //    var result = new List<string>();
        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(new FileStream(Directory.GetCurrentDirectory() + $"\\wwwroot\\files\\{filename}", FileMode.Open, FileAccess.Read)))
        //        {
        //            var line = string.Empty;
        //            while ((line = sr.ReadLine()) != null)
        //            {
        //                // Adding.
        //                result.Add(line);
        //            }

        //            return result;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.Write(ex);
        //    }

        //    return result;
        //}
    }
}
