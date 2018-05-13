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
Public Class dsAll
    Inherits DataSet
    
    Private tableNewOrders As NewOrdersDataTable
    
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
            If (Not (ds.Tables("NewOrders")) Is Nothing) Then
                Me.Tables.Add(New NewOrdersDataTable(ds.Tables("NewOrders")))
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
    Public ReadOnly Property NewOrders As NewOrdersDataTable
        Get
            Return Me.tableNewOrders
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsAll = CType(MyBase.Clone,dsAll)
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
        If (Not (ds.Tables("NewOrders")) Is Nothing) Then
            Me.Tables.Add(New NewOrdersDataTable(ds.Tables("NewOrders")))
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
        Me.tableNewOrders = CType(Me.Tables("NewOrders"),NewOrdersDataTable)
        If (Not (Me.tableNewOrders) Is Nothing) Then
            Me.tableNewOrders.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsAll"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsAll.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableNewOrders = New NewOrdersDataTable
        Me.Tables.Add(Me.tableNewOrders)
    End Sub
    
    Private Function ShouldSerializeNewOrders() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub NewOrdersRowChangeEventHandler(ByVal sender As Object, ByVal e As NewOrdersRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class NewOrdersDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnOrderID As DataColumn
        
        Private columnCustomerID As DataColumn
        
        Private columnEmployeeID As DataColumn
        
        Private columnOrderDate As DataColumn
        
        Private columnRequiredDate As DataColumn
        
        Private columnShippedDate As DataColumn
        
        Private columnShipVia As DataColumn
        
        Private columnFreight As DataColumn
        
        Private columnShipName As DataColumn
        
        Private columnShipAddress As DataColumn
        
        Private columnShipCity As DataColumn
        
        Private columnShipRegion As DataColumn
        
        Private columnShipPostalCode As DataColumn
        
        Private columnShipCountry As DataColumn
        
        Friend Sub New()
            MyBase.New("NewOrders")
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
        
        Friend ReadOnly Property OrderIDColumn As DataColumn
            Get
                Return Me.columnOrderID
            End Get
        End Property
        
        Friend ReadOnly Property CustomerIDColumn As DataColumn
            Get
                Return Me.columnCustomerID
            End Get
        End Property
        
        Friend ReadOnly Property EmployeeIDColumn As DataColumn
            Get
                Return Me.columnEmployeeID
            End Get
        End Property
        
        Friend ReadOnly Property OrderDateColumn As DataColumn
            Get
                Return Me.columnOrderDate
            End Get
        End Property
        
        Friend ReadOnly Property RequiredDateColumn As DataColumn
            Get
                Return Me.columnRequiredDate
            End Get
        End Property
        
        Friend ReadOnly Property ShippedDateColumn As DataColumn
            Get
                Return Me.columnShippedDate
            End Get
        End Property
        
        Friend ReadOnly Property ShipViaColumn As DataColumn
            Get
                Return Me.columnShipVia
            End Get
        End Property
        
        Friend ReadOnly Property FreightColumn As DataColumn
            Get
                Return Me.columnFreight
            End Get
        End Property
        
        Friend ReadOnly Property ShipNameColumn As DataColumn
            Get
                Return Me.columnShipName
            End Get
        End Property
        
        Friend ReadOnly Property ShipAddressColumn As DataColumn
            Get
                Return Me.columnShipAddress
            End Get
        End Property
        
        Friend ReadOnly Property ShipCityColumn As DataColumn
            Get
                Return Me.columnShipCity
            End Get
        End Property
        
        Friend ReadOnly Property ShipRegionColumn As DataColumn
            Get
                Return Me.columnShipRegion
            End Get
        End Property
        
        Friend ReadOnly Property ShipPostalCodeColumn As DataColumn
            Get
                Return Me.columnShipPostalCode
            End Get
        End Property
        
        Friend ReadOnly Property ShipCountryColumn As DataColumn
            Get
                Return Me.columnShipCountry
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As NewOrdersRow
            Get
                Return CType(Me.Rows(index),NewOrdersRow)
            End Get
        End Property
        
        Public Event NewOrdersRowChanged As NewOrdersRowChangeEventHandler
        
        Public Event NewOrdersRowChanging As NewOrdersRowChangeEventHandler
        
        Public Event NewOrdersRowDeleted As NewOrdersRowChangeEventHandler
        
        Public Event NewOrdersRowDeleting As NewOrdersRowChangeEventHandler
        
        Public Overloads Sub AddNewOrdersRow(ByVal row As NewOrdersRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddNewOrdersRow(ByVal CustomerID As String, ByVal EmployeeID As Integer, ByVal OrderDate As Date, ByVal RequiredDate As Date, ByVal ShippedDate As Date, ByVal ShipVia As Integer, ByVal Freight As Decimal, ByVal ShipName As String, ByVal ShipAddress As String, ByVal ShipCity As String, ByVal ShipRegion As String, ByVal ShipPostalCode As String, ByVal ShipCountry As String) As NewOrdersRow
            Dim rowNewOrdersRow As NewOrdersRow = CType(Me.NewRow,NewOrdersRow)
            rowNewOrdersRow.ItemArray = New Object() {Nothing, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry}
            Me.Rows.Add(rowNewOrdersRow)
            Return rowNewOrdersRow
        End Function
        
        Public Function FindByOrderID(ByVal OrderID As Integer) As NewOrdersRow
            Return CType(Me.Rows.Find(New Object() {OrderID}),NewOrdersRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As NewOrdersDataTable = CType(MyBase.Clone,NewOrdersDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New NewOrdersDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnOrderID = Me.Columns("OrderID")
            Me.columnCustomerID = Me.Columns("CustomerID")
            Me.columnEmployeeID = Me.Columns("EmployeeID")
            Me.columnOrderDate = Me.Columns("OrderDate")
            Me.columnRequiredDate = Me.Columns("RequiredDate")
            Me.columnShippedDate = Me.Columns("ShippedDate")
            Me.columnShipVia = Me.Columns("ShipVia")
            Me.columnFreight = Me.Columns("Freight")
            Me.columnShipName = Me.Columns("ShipName")
            Me.columnShipAddress = Me.Columns("ShipAddress")
            Me.columnShipCity = Me.Columns("ShipCity")
            Me.columnShipRegion = Me.Columns("ShipRegion")
            Me.columnShipPostalCode = Me.Columns("ShipPostalCode")
            Me.columnShipCountry = Me.Columns("ShipCountry")
        End Sub
        
        Private Sub InitClass()
            Me.columnOrderID = New DataColumn("OrderID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrderID)
            Me.columnCustomerID = New DataColumn("CustomerID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCustomerID)
            Me.columnEmployeeID = New DataColumn("EmployeeID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEmployeeID)
            Me.columnOrderDate = New DataColumn("OrderDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrderDate)
            Me.columnRequiredDate = New DataColumn("RequiredDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRequiredDate)
            Me.columnShippedDate = New DataColumn("ShippedDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShippedDate)
            Me.columnShipVia = New DataColumn("ShipVia", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipVia)
            Me.columnFreight = New DataColumn("Freight", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFreight)
            Me.columnShipName = New DataColumn("ShipName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipName)
            Me.columnShipAddress = New DataColumn("ShipAddress", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipAddress)
            Me.columnShipCity = New DataColumn("ShipCity", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipCity)
            Me.columnShipRegion = New DataColumn("ShipRegion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipRegion)
            Me.columnShipPostalCode = New DataColumn("ShipPostalCode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipPostalCode)
            Me.columnShipCountry = New DataColumn("ShipCountry", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipCountry)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnOrderID}, true))
            Me.columnOrderID.AutoIncrement = true
            Me.columnOrderID.AllowDBNull = false
            Me.columnOrderID.ReadOnly = true
            Me.columnOrderID.Unique = true
        End Sub
        
        Public Function NewNewOrdersRow() As NewOrdersRow
            Return CType(Me.NewRow,NewOrdersRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New NewOrdersRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(NewOrdersRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.NewOrdersRowChangedEvent) Is Nothing) Then
                RaiseEvent NewOrdersRowChanged(Me, New NewOrdersRowChangeEvent(CType(e.Row,NewOrdersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.NewOrdersRowChangingEvent) Is Nothing) Then
                RaiseEvent NewOrdersRowChanging(Me, New NewOrdersRowChangeEvent(CType(e.Row,NewOrdersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.NewOrdersRowDeletedEvent) Is Nothing) Then
                RaiseEvent NewOrdersRowDeleted(Me, New NewOrdersRowChangeEvent(CType(e.Row,NewOrdersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.NewOrdersRowDeletingEvent) Is Nothing) Then
                RaiseEvent NewOrdersRowDeleting(Me, New NewOrdersRowChangeEvent(CType(e.Row,NewOrdersRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveNewOrdersRow(ByVal row As NewOrdersRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class NewOrdersRow
        Inherits DataRow
        
        Private tableNewOrders As NewOrdersDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableNewOrders = CType(Me.Table,NewOrdersDataTable)
        End Sub
        
        Public Property OrderID As Integer
            Get
                Return CType(Me(Me.tableNewOrders.OrderIDColumn),Integer)
            End Get
            Set
                Me(Me.tableNewOrders.OrderIDColumn) = value
            End Set
        End Property
        
        Public Property CustomerID As String
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.CustomerIDColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.CustomerIDColumn) = value
            End Set
        End Property
        
        Public Property EmployeeID As Integer
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.EmployeeIDColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.EmployeeIDColumn) = value
            End Set
        End Property
        
        Public Property OrderDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.OrderDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.OrderDateColumn) = value
            End Set
        End Property
        
        Public Property RequiredDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.RequiredDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.RequiredDateColumn) = value
            End Set
        End Property
        
        Public Property ShippedDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.ShippedDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.ShippedDateColumn) = value
            End Set
        End Property
        
        Public Property ShipVia As Integer
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.ShipViaColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.ShipViaColumn) = value
            End Set
        End Property
        
        Public Property Freight As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.FreightColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.FreightColumn) = value
            End Set
        End Property
        
        Public Property ShipName As String
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.ShipNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.ShipNameColumn) = value
            End Set
        End Property
        
        Public Property ShipAddress As String
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.ShipAddressColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.ShipAddressColumn) = value
            End Set
        End Property
        
        Public Property ShipCity As String
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.ShipCityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.ShipCityColumn) = value
            End Set
        End Property
        
        Public Property ShipRegion As String
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.ShipRegionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.ShipRegionColumn) = value
            End Set
        End Property
        
        Public Property ShipPostalCode As String
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.ShipPostalCodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.ShipPostalCodeColumn) = value
            End Set
        End Property
        
        Public Property ShipCountry As String
            Get
                Try 
                    Return CType(Me(Me.tableNewOrders.ShipCountryColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableNewOrders.ShipCountryColumn) = value
            End Set
        End Property
        
        Public Function IsCustomerIDNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.CustomerIDColumn)
        End Function
        
        Public Sub SetCustomerIDNull()
            Me(Me.tableNewOrders.CustomerIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsEmployeeIDNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.EmployeeIDColumn)
        End Function
        
        Public Sub SetEmployeeIDNull()
            Me(Me.tableNewOrders.EmployeeIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsOrderDateNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.OrderDateColumn)
        End Function
        
        Public Sub SetOrderDateNull()
            Me(Me.tableNewOrders.OrderDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRequiredDateNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.RequiredDateColumn)
        End Function
        
        Public Sub SetRequiredDateNull()
            Me(Me.tableNewOrders.RequiredDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShippedDateNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.ShippedDateColumn)
        End Function
        
        Public Sub SetShippedDateNull()
            Me(Me.tableNewOrders.ShippedDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipViaNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.ShipViaColumn)
        End Function
        
        Public Sub SetShipViaNull()
            Me(Me.tableNewOrders.ShipViaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFreightNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.FreightColumn)
        End Function
        
        Public Sub SetFreightNull()
            Me(Me.tableNewOrders.FreightColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipNameNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.ShipNameColumn)
        End Function
        
        Public Sub SetShipNameNull()
            Me(Me.tableNewOrders.ShipNameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipAddressNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.ShipAddressColumn)
        End Function
        
        Public Sub SetShipAddressNull()
            Me(Me.tableNewOrders.ShipAddressColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipCityNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.ShipCityColumn)
        End Function
        
        Public Sub SetShipCityNull()
            Me(Me.tableNewOrders.ShipCityColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipRegionNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.ShipRegionColumn)
        End Function
        
        Public Sub SetShipRegionNull()
            Me(Me.tableNewOrders.ShipRegionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipPostalCodeNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.ShipPostalCodeColumn)
        End Function
        
        Public Sub SetShipPostalCodeNull()
            Me(Me.tableNewOrders.ShipPostalCodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipCountryNull() As Boolean
            Return Me.IsNull(Me.tableNewOrders.ShipCountryColumn)
        End Function
        
        Public Sub SetShipCountryNull()
            Me(Me.tableNewOrders.ShipCountryColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class NewOrdersRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As NewOrdersRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As NewOrdersRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As NewOrdersRow
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