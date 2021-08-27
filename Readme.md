<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2101)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to calculate Percent and Absolute Variations in a custom direction: from right to left


<p>This example shows how to use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellDisplayTexttopic">PivotGridControl.CustomCellDisplayText</a> or <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraPivotGridPivotGridControl_CustomCellValuetopic">PivotGridControl.CustomCellValue</a> event to display a field values as if its <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridFieldBase_SummaryDisplayTypetopic">PivotGridFieldBase.SummaryDisplayType</a> property is set to <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressDataPivotGridPivotSummaryDisplayTypeEnumtopic">PercentVariation</a>, but the values are read in the reverse direction (from right to left).</p>
<p>To accomplish this task, you should create a new PivotGridField, bind it to the DataField, and hide the grand totals for this field via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridFieldOptions_ShowGrandTotaltopic">PivotGridFieldOptions.ShowGrandTotal</a> property. After that, you will need to manually calculate a display text for this field in the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellDisplayTexttopic">CustomCellDisplayText</a> or <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraPivotGridPivotGridControl_CustomCellValuetopic">CustomCellValue</a> event, as shown in the example project.<br /><br />Note that it is also possible to access cell corresponding to a <strong>specific Field Value</strong> instead of the next/previous one. This functionality is demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E2125">Get summary values for previous period while calculating the current one</a> example.</p>

<br/>


