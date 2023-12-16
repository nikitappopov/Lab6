using System;
using System.Collections.Generic;

public class CodeWars
{
    public static string Scanner(int[][] qrcode)
    {
        int i = 20;
        int j = 20;
        string matrica = "";
        while (i != 8 && j != 19)
        {
            if ((i + j) % 2 == 0)
            {
                if (qrcode[i][j] == 1) qrcode[i][j] = 0;
                else qrcode[i][j] = 1;
            }
            matrica += qrcode[i][j] + "";
            j -= 1;
            if ((i + j) % 2 == 0)
            {
                if (qrcode[i][j] == 1) qrcode[i][j] = 0;
                else qrcode[i][j] = 1;
            }
            matrica += qrcode[i][j] + "";
            j += 1;
            i -= 1;
        }
        i = 9;
        j = 18;
        do
        {
            if ((i + j) % 2 == 0)
            {
                if (qrcode[i][j] == 1) qrcode[i][j] = 0;
                else qrcode[i][j] = 1;
            }
            matrica += qrcode[i][j] + "";
            j -= 1;
            if ((i + j) % 2 == 0)
            {
                if (qrcode[i][j] == 1) qrcode[i][j] = 0;
                else qrcode[i][j] = 1;
            }
            matrica += qrcode[i][j] + "";
            j += 1;
            i += 1;

        } while (i != 21 && j != 16);
        i = 20;
        j = 16;
        while (i != 8 && j != 15)
        {
            if ((i + j) % 2 == 0)
            {
                if (qrcode[i][j] == 1) qrcode[i][j] = 0;
                else qrcode[i][j] = 1;
            }
            matrica += qrcode[i][j] + "";
            j -= 1;
            if ((i + j) % 2 == 0)
            {
                if (qrcode[i][j] == 1) qrcode[i][j] = 0;
                else qrcode[i][j] = 1;
            }
            matrica += qrcode[i][j] + "";
            j += 1;
            i -= 1;
        }
        i = 9;
        j = 14;
        do
        {
            if ((i + j) % 2 == 0)
            {
                if (qrcode[i][j] == 1) qrcode[i][j] = 0;
                else qrcode[i][j] = 1;
            }
            matrica += qrcode[i][j] + "";
            j -= 1;
            if ((i + j) % 2 == 0)
            {
                if (qrcode[i][j] == 1) qrcode[i][j] = 0;
                else qrcode[i][j] = 1;
            }
            matrica += qrcode[i][j] + "";
            j += 1;
            i += 1;

        } while (i != 11 && j != 13);
        Console.WriteLine(matrica);
        string br = "";
        int t = 0;
        for (int k = 11; k > 3; k--)
        {
            br = matrica[k] + "" + br;
        }
        t = Convert.ToInt32(br, 2);
        br = "";
        int b = 0;
        string slova = "";
        for (int k = 11 + t * 8; k > 11; k--)
        {
            br = matrica[k] + "" + br;
            if (br.Length == 8)
            {
                b = Convert.ToInt32(br, 2);
                slova = (char)b + "" + slova;
                br = "";
            }
        }
        return slova;
    }
}
