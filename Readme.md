<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2147)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [GridViewSearch.cs](./CS/WindowsApplication1/GridViewSearch.cs) (VB: [GridViewSearch.vb](./VB/WindowsApplication1/GridViewSearch.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to locate a row by display text


<p>Generally, the following methods can be used to find a necessary row in the GridView:<br />
<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnView_LocateByDisplayTexttopic">LocateByDisplayText</a><br />
<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnView_LocateByValuetopic">LocateByValue</a></p><p>However, there can be a situation when you need to perform a custom algorithm for finding a necessary row. For example, if you want to find all rows whose values contain a specific substring. In this case, you need to traverse through all rows manually, as described in the <a href="https://www.devexpress.com/Support/Center/p/A1245">How to traverse grid rows in their visible order</a> Knowledge Base article.</p><p>This example demonstrates this approach in action.</p>

<br/>


