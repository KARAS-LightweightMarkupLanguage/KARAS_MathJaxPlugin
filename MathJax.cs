﻿
// Copyright (c) 2014, Daiki Umeda (XJINE) - lightweightmarkuplanguage.com
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
// 
// * Redistributions of source code must retain the above copyright notice, this
//   list of conditions and the following disclaimer.
// 
// * Redistributions in binary form must reproduce the above copyright notice,
//   this list of conditions and the following disclaimer in the documentation
//   and/or other materials provided with the distribution.
// 
// * Neither the name of the copyright holder nor the names of its
//   contributors may be used to endorse or promote products derived from
//   this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// MathJax - http://www.mathjax.org/
// MathJax is distributed under the Apache License, Version 2.0.
// Thanks a lot MathJax team.
// 
// [How to Use]
// Add following code to your html head.
// ----------------------------------------------------------------------------
// <script type="text/javascript"
// src="http://cdn.mathjax.org/mathjax/latest/MathJax.js?config=TeX-AMS_HTML">
// </script>
// ----------------------------------------------------------------------------
// 
// [Syntax Sample]
// = Convert type (Inline type MathJax)
//
// [[mathjax :: y=x^{2}+2x+1]]
// 
// = Action type (Block type MathJax)
// 
// [[[mathjax ::
//    \sum_{n=1}^{N}n = 1 + 2 + 3 + 4 + \cdots + (N-3) + (N-2) + (N-1) + N \tag{1}
// ]]]

public static class MathJax
{
    public static string convert(string markedupText, string[] options)
    {
        markedupText = markedupText.Trim();
        markedupText = markedupText.Replace("\\", "\\\\");
        markedupText = "\\\\(" + markedupText + "\\\\)";
        return markedupText;
    }

    public static string action(string text, string[] options)
    {
        string markedupText = options[0].Trim();
        markedupText = "<div class=\"mathjaxframe\">\n\\\\[\n"
                        + markedupText.Replace("\\", "\\\\")
                        + "\n\\\\]\n</div>";
        return markedupText;
    }
}