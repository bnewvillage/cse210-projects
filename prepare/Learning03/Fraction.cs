using System;
using System.Runtime.InteropServices;

public class Fraction{
    private int _top;
    private int _bottom;

    public int GetTop(){
        return _top;
    }
    public int GetBottom(){
        return _bottom;
    }

    public void SetTOp(int top){
        _top = top;
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString(){
        int fraction = _top / _bottom;
        return fraction.ToString();
    }

    public double GetFractionDouble(){
        double fraction = (double)_top/(double)_bottom;
        return fraction;
    }
}