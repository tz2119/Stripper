using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Diagnostics;

namespace Stripper {

    /// <summary>
    /// 
    /// </summary>
    public class StripperUtils {

        public const int WM_MOUSEACTIVATE = 0x21;
        public const int MA_ACTIVATE = 1;
        public const int MA_ACTIVATEANDEAT = 2;
        public const int MA_NOACTIVATE = 3;
        public const int MA_NOACTIVATEANDEAT = 4;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static object LoadFromBinaryFile(string path) {
            object obj = null;
            try {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter f = new BinaryFormatter();
                obj = f.Deserialize(fs);
                fs.Close();

            } catch (SerializationException e) {
                MessageBox.Show("ファイル形式が不正です。", "メッセージ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception e) {
                Debug.WriteLine(e.ToString());
            }
            return obj;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="path"></param>
        public static void SaveToBinaryFile(object obj, string path) {
            try {
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, obj);
                fs.Close();
            } catch (Exception e) {
                Debug.WriteLine(e.ToString());
            }
        }

    }
}
