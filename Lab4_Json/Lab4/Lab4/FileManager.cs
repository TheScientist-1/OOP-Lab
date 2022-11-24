using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class FileManager
    {
        public static bool SaveFile()
        {
            bool saved = false;
            if (String.IsNullOrEmpty(Helper.Path))
            {SaveFileDialog saveFileDialog = new SaveFileDialog
                {   InitialDirectory = @"D:\",
                    Title = "Save",
                    DefaultExt = "json",
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Helper.Path = saveFileDialog.FileName;
                    JsonMaster.SerializeToJson(Helper.Path, Helper.Data);
                    saved = true;
                }
            }
            return saved;
        }


        public static void OpenFile()
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Open",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "json"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Helper.Path = openFileDialog1.FileName;
                    Helper.Data = JsonMaster.DeserialiseFromJson(Helper.Path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Inappripriate structure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        public static bool CreateFile()
        {
            bool saved = false;
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Save Json",

                Filter = "json files (*.json)|*.json;",
                DefaultExt = "json",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Helper.Path = saveFileDialog.FileName;
                JsonMaster.SerializeToJson(Helper.Path, Helper.Data);
                saved = true;
            }
            return saved;
        }



    }

}
