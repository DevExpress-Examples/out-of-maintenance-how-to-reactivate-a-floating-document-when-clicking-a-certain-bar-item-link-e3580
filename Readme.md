<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617490/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3580)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to reactivate a floating document when clicking a certain bar item link


<p>When the user clicks a bar item placed on a main Form, an active float document is deactivated. This makes it impossible to implement the scenario when the main Form toolbar is shared between several documents. This example demonstrates how to overcome this difficulty. </p><p>For this purpose, it is necessary to handle the BaseView.DocumentDeactivated event and remember the deactivated document if it is floating, and if the mouse cursor is hovering above a certain bar item link.</p><p>In the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsBarItem_ItemClicktopic"><u>BarItem.ItemClick</u></a> event handler, restore the deactivated document if necessary, and then perform the necessary action.</p>

<br/>


