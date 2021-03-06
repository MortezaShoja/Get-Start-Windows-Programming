﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsP
    Inherits DataSet
    
    Private tablePhones As PhonesDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Phones")) Is Nothing) Then
                Me.Tables.Add(New PhonesDataTable(ds.Tables("Phones")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Phones As PhonesDataTable
        Get
            Return Me.tablePhones
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsP = CType(MyBase.Clone,dsP)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Phones")) Is Nothing) Then
            Me.Tables.Add(New PhonesDataTable(ds.Tables("Phones")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tablePhones = CType(Me.Tables("Phones"),PhonesDataTable)
        If (Not (Me.tablePhones) Is Nothing) Then
            Me.tablePhones.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsP"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsP.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablePhones = New PhonesDataTable
        Me.Tables.Add(Me.tablePhones)
    End Sub
    
    Private Function ShouldSerializePhones() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub PhonesRowChangeEventHandler(ByVal sender As Object, ByVal e As PhonesRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class PhonesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnFamily As DataColumn
        
        Private columnPhone As DataColumn
        
        Friend Sub New()
            MyBase.New("Phones")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property FamilyColumn As DataColumn
            Get
                Return Me.columnFamily
            End Get
        End Property
        
        Friend ReadOnly Property PhoneColumn As DataColumn
            Get
                Return Me.columnPhone
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As PhonesRow
            Get
                Return CType(Me.Rows(index),PhonesRow)
            End Get
        End Property
        
        Public Event PhonesRowChanged As PhonesRowChangeEventHandler
        
        Public Event PhonesRowChanging As PhonesRowChangeEventHandler
        
        Public Event PhonesRowDeleted As PhonesRowChangeEventHandler
        
        Public Event PhonesRowDeleting As PhonesRowChangeEventHandler
        
        Public Overloads Sub AddPhonesRow(ByVal row As PhonesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddPhonesRow(ByVal Family As String, ByVal Phone As String) As PhonesRow
            Dim rowPhonesRow As PhonesRow = CType(Me.NewRow,PhonesRow)
            rowPhonesRow.ItemArray = New Object() {Family, Phone}
            Me.Rows.Add(rowPhonesRow)
            Return rowPhonesRow
        End Function
        
        Public Function FindByFamily(ByVal Family As String) As PhonesRow
            Return CType(Me.Rows.Find(New Object() {Family}),PhonesRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As PhonesDataTable = CType(MyBase.Clone,PhonesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New PhonesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnFamily = Me.Columns("Family")
            Me.columnPhone = Me.Columns("Phone")
        End Sub
        
        Private Sub InitClass()
            Me.columnFamily = New DataColumn("Family", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFamily)
            Me.columnPhone = New DataColumn("Phone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhone)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnFamily}, true))
            Me.columnFamily.AllowDBNull = false
            Me.columnFamily.Unique = true
        End Sub
        
        Public Function NewPhonesRow() As PhonesRow
            Return CType(Me.NewRow,PhonesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New PhonesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(PhonesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.PhonesRowChangedEvent) Is Nothing) Then
                RaiseEvent PhonesRowChanged(Me, New PhonesRowChangeEvent(CType(e.Row,PhonesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.PhonesRowChangingEvent) Is Nothing) Then
                RaiseEvent PhonesRowChanging(Me, New PhonesRowChangeEvent(CType(e.Row,PhonesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.PhonesRowDeletedEvent) Is Nothing) Then
                RaiseEvent PhonesRowDeleted(Me, New PhonesRowChangeEvent(CType(e.Row,PhonesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.PhonesRowDeletingEvent) Is Nothing) Then
                RaiseEvent PhonesRowDeleting(Me, New PhonesRowChangeEvent(CType(e.Row,PhonesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovePhonesRow(ByVal row As PhonesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class PhonesRow
        Inherits DataRow
        
        Private tablePhones As PhonesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablePhones = CType(Me.Table,PhonesDataTable)
        End Sub
        
        Public Property Family As String
            Get
                Return CType(Me(Me.tablePhones.FamilyColumn),String)
            End Get
            Set
                Me(Me.tablePhones.FamilyColumn) = value
            End Set
        End Property
        
        Public Property Phone As String
            Get
                Try 
                    Return CType(Me(Me.tablePhones.PhoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablePhones.PhoneColumn) = value
            End Set
        End Property
        
        Public Function IsPhoneNull() As Boolean
            Return Me.IsNull(Me.tablePhones.PhoneColumn)
        End Function
        
        Public Sub SetPhoneNull()
            Me(Me.tablePhones.PhoneColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class PhonesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As PhonesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As PhonesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As PhonesRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
