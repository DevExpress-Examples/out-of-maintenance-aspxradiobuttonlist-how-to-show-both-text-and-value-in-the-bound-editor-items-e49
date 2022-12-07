Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub radioButtonList_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		Dim rbl As ASPxRadioButtonList = TryCast(sender, ASPxRadioButtonList)
		For Each item As ListEditItem In rbl.Items
			item.Text = String.Format("{0} ({1})", item.Text, item.Value)
		Next item
	End Sub
End Class