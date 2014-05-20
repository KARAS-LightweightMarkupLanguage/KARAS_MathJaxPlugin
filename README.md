# MathJax plugin for KARAS



## About

This is plugin to use *MathJax* in KARAS(Lightweight Markup Language).
If you want to get more info about KARAS, please visit [lightweightmarkuplanguage.com](http://lightweightmarkuplanguage.com).
If you want to get more info about MathJax, please visit [mathjax.org](http://http://www.mathjax.org/).


## How to Use

Put the plugin into your ``plugins`` directory, and paste following code into your html.

```html
<script type="text/javascript"
src="http://cdn.mathjax.org/mathjax/latest/MathJax.js?config=TeX-AMS_HTML">
</script>
```

## Javascript ver.

If you want to use javascript ver. in real-time, add following code after your ``KARAS.convert``.

```javascript
// MathJax.Hub.Queue(["Typeset", MathJax.Hub, "your output area id"]);
```
More info about this is described in Javascript ver source.
And ```MathJaxJsPage.html``` is one of sample to use in real-time.
But please note, maybe this has a problem on Mac-OS Safari.
Javascript is hanged up when the each key stroke speed is fast.



## System requirements

Same as each KARAS version.



## License

MathJax plugin for KARAS is licensed under BSD.
MathJax is licensed under Apache2.0.