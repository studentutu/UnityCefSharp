﻿using System.Collections.Generic;
using UnityEngine;

namespace CefClient.Chromium
{
    public static class CefKeys
    {
        public static Dictionary<KeyCode, int> KeyCodeMap = new Dictionary<KeyCode, int>
        {
            {KeyCode.Backspace, 0x08},
            {KeyCode.Delete, 0x2E},
            {KeyCode.Tab, 0x09},
            {KeyCode.Clear, 0x0C},
            {KeyCode.Return, 0x0D},
            {KeyCode.Pause, 0x13},
            {KeyCode.Escape, 0x1B},
            {KeyCode.Space, 0x20},
            {KeyCode.UpArrow, 0x26},
            {KeyCode.DownArrow, 0x28},
            {KeyCode.LeftArrow, 0x25},
            {KeyCode.RightArrow, 0x27},
            {KeyCode.Insert, 0x2D},
            {KeyCode.Home, 0x24},
            {KeyCode.End, 0x23},
            {KeyCode.PageUp, 0x21},
            {KeyCode.PageDown, 0x22},
            {KeyCode.Keypad0, 0x60},
            {KeyCode.Keypad1, 0x61},
            {KeyCode.Keypad2, 0x62},
            {KeyCode.Keypad3, 0x63},
            {KeyCode.Keypad4, 0x64},
            {KeyCode.Keypad5, 0x65},
            {KeyCode.Keypad6, 0x66},
            {KeyCode.Keypad7, 0x67},
            {KeyCode.Keypad8, 0x68},
            {KeyCode.Keypad9, 0x69},
            {KeyCode.KeypadMultiply, 0x6A},
            {KeyCode.KeypadDivide, 0x6F},
            {KeyCode.KeypadPlus, 0x6B},
            {KeyCode.KeypadMinus, 0x6D},
            {KeyCode.F1, 0x70},
            {KeyCode.F2, 0x71},
            {KeyCode.F3, 0x72},
            {KeyCode.F4, 0x73},
            {KeyCode.F5, 0x74},
            {KeyCode.F6, 0x75},
            {KeyCode.F7, 0x76},
            {KeyCode.F8, 0x77},
            {KeyCode.F9, 0x78},
            {KeyCode.F10, 0x79},
            {KeyCode.F11, 0x7A},
            {KeyCode.F12, 0x7B},
            {KeyCode.F13, 0x7C},
            {KeyCode.F14, 0x7D},
            {KeyCode.F15, 0x7E},
            {KeyCode.Alpha0, 0x30},
            {KeyCode.Alpha1, 0x31},
            {KeyCode.Alpha2, 0x32},
            {KeyCode.Alpha3, 0x33},
            {KeyCode.Alpha4, 0x34},
            {KeyCode.Alpha5, 0x35},
            {KeyCode.Alpha6, 0x36},
            {KeyCode.Alpha7, 0x37},
            {KeyCode.Alpha8, 0x38},
            {KeyCode.Alpha9, 0x39},
            {KeyCode.DoubleQuote, 0xDE},
            {KeyCode.Quote, 0xDE},
            {KeyCode.Period, 0xBE},
            {KeyCode.Comma, 0xBC},
            {KeyCode.Plus, 0xBB},
            {KeyCode.Minus, 0xBD},
            {KeyCode.Slash, 0xBF},
            {KeyCode.A, 0x41},
            {KeyCode.B, 0x42},
            {KeyCode.C, 0x43},
            {KeyCode.D, 0x44},
            {KeyCode.E, 0x45},
            {KeyCode.F, 0x46},
            {KeyCode.G, 0x47},
            {KeyCode.H, 0x48},
            {KeyCode.I, 0x49},
            {KeyCode.J, 0x4A},
            {KeyCode.K, 0x4B},
            {KeyCode.L, 0x4C},
            {KeyCode.M, 0x4D},
            {KeyCode.N, 0x4E},
            {KeyCode.O, 0x4F},
            {KeyCode.P, 0x50},
            {KeyCode.Q, 0x51},
            {KeyCode.R, 0x52},
            {KeyCode.S, 0x53},
            {KeyCode.T, 0x54},
            {KeyCode.U, 0x55},
            {KeyCode.V, 0x56},
            {KeyCode.W, 0x57},
            {KeyCode.X, 0x58},
            {KeyCode.Y, 0x59},
            {KeyCode.Z, 0x5A},
            //{KeyCode.LeftCurlyBracket, 0xDB},
            //{KeyCode.Pipe, 0xDC},
            //{KeyCode.RightCurlyBracket, 0xDD},
            //{KeyCode.Tilde, 0xC0},
            {KeyCode.Numlock, 0x90},
            {KeyCode.CapsLock, 0x14},
            {KeyCode.ScrollLock, 0x91},
            {KeyCode.LeftShift, 0xA0},
            {KeyCode.RightShift, 0xA1},
            {KeyCode.LeftControl, 0xA2},
            {KeyCode.RightControl, 0xA3},
            {KeyCode.LeftAlt, 0x12},
            {KeyCode.RightAlt, 0x12},
            {KeyCode.Print, 0x2A},
        };

        public static List<KeyCode> CharKeys = new List<KeyCode>
        {
            KeyCode.A,
            KeyCode.B,
            KeyCode.C,
            KeyCode.D,
            KeyCode.E,
            KeyCode.F,
            KeyCode.G,
            KeyCode.H,
            KeyCode.I,
            KeyCode.J,
            KeyCode.K,
            KeyCode.L,
            KeyCode.M,
            KeyCode.N,
            KeyCode.O,
            KeyCode.P,
            KeyCode.Q,
            KeyCode.R,
            KeyCode.S,
            KeyCode.T,
            KeyCode.U,
            KeyCode.V,
            KeyCode.W,
            KeyCode.X,
            KeyCode.Y,
            KeyCode.Z,
            KeyCode.Alpha0,
            KeyCode.Alpha1,
            KeyCode.Alpha2,
            KeyCode.Alpha3,
            KeyCode.Alpha4,
            KeyCode.Alpha5,
            KeyCode.Alpha6,
            KeyCode.Alpha7,
            KeyCode.Alpha8,
            KeyCode.Alpha9,
            KeyCode.DoubleQuote,
            KeyCode.Quote,
            KeyCode.Period,
            KeyCode.Comma,
            KeyCode.Plus,
            KeyCode.Minus,
            KeyCode.Slash,
            KeyCode.Keypad0,
            KeyCode.Keypad1,
            KeyCode.Keypad2,
            KeyCode.Keypad3,
            KeyCode.Keypad4,
            KeyCode.Keypad5,
            KeyCode.Keypad6,
            KeyCode.Keypad7,
            KeyCode.Keypad8,
            KeyCode.Keypad9,
            KeyCode.KeypadMultiply,
            KeyCode.KeypadDivide,
            KeyCode.KeypadPlus,
            KeyCode.KeypadMinus,
            KeyCode.Space,
        };
    }
}
