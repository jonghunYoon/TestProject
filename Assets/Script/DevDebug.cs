#define DEV_DEBUG

using UnityEngine;
using System.Collections;

public class DevDebug
{
    public class Log
    {
        [System.Diagnostics.Conditional("DEV_DEBUG")]
        public static void Normal(System.Object msg)
        {
            UnityEngine.Debug.Log(Frame() + msg);
        }

        public static void Warrning(System.Object msg)
        {
            UnityEngine.Debug.Log(Frame() + msg);
        }

        public static void Error(System.Object msg)
        {
            UnityEngine.Debug.Log(Frame() + msg);
        }
        public static string Frame()
        {
            return string.Format("[{0}] : ", Time.frameCount);
        }
    }

    public class Draw
    {
        public static void Line(Vector3 start, Vector3 end, Color color, float duration)
        {
            Debug.DrawLine(start, end, color, duration);
        }
    }
    public static void Assert(UnityEngine.Object obj)
    {
        if(null == obj)
        {
            var stackTrace = new System.Diagnostics.StackTrace();
            var frame = stackTrace.GetFrame(1);

            string message = "[!!!](Assert)[!!!] : " + frame.GetMethod().Name +
            "( " + frame.GetFileName() + " [line : " +
            frame.GetFileLineNumber() + " ] )";

        }
    }

}
