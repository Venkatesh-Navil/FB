using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class clsGlobalValues
    {
        public static string tour;
        public static int MIdd;
        public static string genttour;
        public static string status;
        public static string Recorder;
        public static string VideoPath;
        public static string RecordingStatus;
        public static double video_recordtime;
        public static string instantVideoRenamePath;
        public static string Tournament
        {
            get
            {
                return tour;
            }
            set
            {
                tour = value;
            }
        }
        public static int mid
        {
            get
            {
                return MIdd;
            }
            set
            {
                MIdd = value;
            }
        }
    }
}
