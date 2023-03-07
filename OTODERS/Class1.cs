using System.Runtime.InteropServices;

public class Win32
{

    [DllImport("User32.Dll")]
    public static extern long SetCursorPos(int x, int y);

    [DllImport("User32.Dll")]
    public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void fare_kontrolu(Int32 dwFlags, Int32 dx, Int32 dy, Int32 cButtons, Int32 dwExtraInfo);
    //Yukarıdaki kodda ise fareyi istediğimiz noktqaya götürüp istediğimiz işlemi yapmamızı sağlıyoruz

    private const int sol_bas = 0x02;
    private const int sol_kaldir = 0x04;
    public static void SolTikla()
    {

        int farenin_x_konumu = Cursor.Position.X;
        int farenin_y_konumu = Cursor.Position.Y;
        // Yine aynı şekilde farenin tıklayacağı konumları ayarlıyoruz

       
        //ve aynı şekilde konum ve tıklanacak tuşların HexaDecimal cinsinden ASCII değerlerini gönderiyoruz ve tıklamasını sağlıyoruz
    }









}

