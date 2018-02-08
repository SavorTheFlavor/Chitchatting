using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTCPClient {
    public class ClientUtil {
        private static List<String> randomNameList;
        private static List<String> randomAttrList;

        //..........这写法...
        public const int IMG_CLOUD = 0;
        public const int IMG_Crayon = 1;
        public const int IMG_DOG = 2;
        public const int IMG_HUSH = 3;
        public const int IMG_loli1 = 4;
        public const int IMG_WOLF = 5;


        private static Random r;
        //静态构造函数，跟java的静态代码块差不多
        static ClientUtil() {
            r = new Random();

            //for convenience sake, this may not be of use
            randomNameList = new List<String>();
            randomNameList.Add("Python");
            randomNameList.Add("CSharp");
            randomNameList.Add("Swift");
            randomNameList.Add("Docker");
            randomNameList.Add("Hadoop");
            randomNameList.Add("Spark");

            randomAttrList = new List<String>();
            randomAttrList.Add("Funny");
            randomAttrList.Add("Crazy");
            randomAttrList.Add("Furious");
            randomAttrList.Add("Adorable");
            randomAttrList.Add("Sily");
            randomAttrList.Add("Lazy");
        }

        public static String getRandomName(){
            return randomNameList[r.Next(randomNameList.Count)] + r.Next(5) + "." + r.Next(9) + "."+r.Next(7);
        }

        public static int getRandomImgFlag() {
            return r.Next(6);
        }

        internal static System.Drawing.Image getImg(int imgFlag) {
            //唉.............
            switch (imgFlag) {
                case 0:
                    return Properties.Resources.cloud;
                case 1:
                    return Properties.Resources.Crayon;
                case 2:
                    return Properties.Resources.dog;
                case 3:
                    return Properties.Resources.hush;
                case 4:
                    return Properties.Resources.loli1;
                case 5:
                    return Properties.Resources.wolf;
                default:
                    return Properties.Resources.loli1;
            }
        }

        
        

    }
}
