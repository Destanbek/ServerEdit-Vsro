#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ServerEditVsro.ProgramDataSet1TableAdapters
{
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.TableAdapterManager")]
	[ToolboxItem(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class TableAdapterManager : Component
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public enum UpdateOrderOption
		{
			InsertUpdateDelete,
			UpdateInsertDelete
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private class SelfReferenceComparer : IComparer<DataRow>
		{
			private DataRelation _relation;

			private int _childFirst;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal SelfReferenceComparer(DataRelation relation, bool childFirst)
			{
				_relation = relation;
				if (childFirst)
				{
					_childFirst = -1;
				}
				else
				{
					_childFirst = 1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private DataRow GetRoot(DataRow row, out int distance)
			{
				Debug.Assert(row != null);
				DataRow result = row;
				distance = 0;
				IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
				dictionary[row] = row;
				DataRow parentRow = row.GetParentRow(_relation, DataRowVersion.Default);
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					distance++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (distance == 0)
				{
					dictionary.Clear();
					dictionary[row] = row;
					DataRow parentRow2 = row.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow2 != null && !dictionary.ContainsKey(parentRow2))
					{
						distance++;
						result = parentRow2;
						dictionary[parentRow2] = parentRow2;
						parentRow2 = parentRow2.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Compare(DataRow row1, DataRow row2)
			{
				if (row1 == row2)
				{
					return 0;
				}
				if (row1 == null)
				{
					return -1;
				}
				if (row2 == null)
				{
					return 1;
				}
				int distance = 0;
				DataRow root = GetRoot(row1, out distance);
				int distance2 = 0;
				DataRow root2 = GetRoot(row2, out distance2);
				if (root == root2)
				{
					return _childFirst * distance.CompareTo(distance2);
				}
				Debug.Assert(root.Table != null && root2.Table != null);
				return (root.Table.Rows.IndexOf(root) >= root2.Table.Rows.IndexOf(root2)) ? 1 : (-1);
			}
		}

		private UpdateOrderOption _updateOrder;

		private Sponsor2TableAdapter _sponsor2TableAdapter;

		private bool _backupDataSetBeforeUpdate;

		private IDbConnection _connection;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public UpdateOrderOption UpdateOrder
		{
			get
			{
				return _updateOrder;
			}
			set
			{
				_updateOrder = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public Sponsor2TableAdapter Sponsor2TableAdapter
		{
			get
			{
				return _sponsor2TableAdapter;
			}
			set
			{
				_sponsor2TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool BackupDataSetBeforeUpdate
		{
			get
			{
				return _backupDataSetBeforeUpdate;
			}
			set
			{
				_backupDataSetBeforeUpdate = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public IDbConnection Connection
		{
			get
			{
				if (_connection != null)
				{
					return _connection;
				}
				if (_sponsor2TableAdapter != null && _sponsor2TableAdapter.Connection != null)
				{
					return _sponsor2TableAdapter.Connection;
				}
				return null;
			}
			set
			{
				_connection = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int TableAdapterInstanceCount
		{
			get
			{
				int num = 0;
				if (_sponsor2TableAdapter != null)
				{
					num++;
				}
				return num;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateUpdatedRows(ProgramDataSet1 dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
		{
			int num = 0;
			if (_sponsor2TableAdapter != null)
			{
				DataRow[] realUpdatedRows = GetRealUpdatedRows(dataSet.Sponsor2.Select(null, null, DataViewRowState.ModifiedCurrent), allAddedRows);
				if (realUpdatedRows != null && realUpdatedRows.Length != 0)
				{
					num += _sponsor2TableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			return num;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private int UpdateInsertedRows(ProgramDataSet1 dataSet, List<DataRow> allAddedRows)
		{
			int num = 0;
			if (_sponsor2TableAdapter != null)
			{
				DataRow[] array = dataSet.Sponsor2.Select(null, null, DataViewRowState.Added);
				if (array != null && array.Length != 0)
				{
					num += _sponsor2TableAdapter.Update(array);
					allAddedRows.AddRange(array);
				}
			}
			return num;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateDeletedRows(ProgramDataSet1 dataSet, List<DataRow> allChangedRows)
		{
			int num = 0;
			if (_sponsor2TableAdapter != null)
			{
				DataRow[] array = dataSet.Sponsor2.Select(null, null, DataViewRowState.Deleted);
				if (array != null && array.Length != 0)
				{
					num += _sponsor2TableAdapter.Update(array);
					allChangedRows.AddRange(array);
				}
			}
			return num;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
		{
			if (updatedRows == null || updatedRows.Length < 1 || allAddedRows == null || allAddedRows.Count < 1)
			{
				return updatedRows;
			}
			List<DataRow> list = new List<DataRow>();
			foreach (DataRow item in updatedRows)
			{
				if (!allAddedRows.Contains(item))
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public virtual int UpdateAll(ProgramDataSet1 dataSet)
		{
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			if (!dataSet.HasChanges())
			{
				return 0;
			}
			if (_sponsor2TableAdapter != null && !MatchTableAdapterConnection(_sponsor2TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			IDbConnection connection = Connection;
			if (connection == null)
			{
				throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
			}
			bool flag = false;
			if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
			{
				connection.Close();
			}
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				flag = true;
			}
			IDbTransaction dbTransaction = connection.BeginTransaction();
			if (dbTransaction == null)
			{
				throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
			}
			List<DataRow> list = new List<DataRow>();
			List<DataRow> list2 = new List<DataRow>();
			List<DataAdapter> list3 = new List<DataAdapter>();
			Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
			int num = 0;
			DataSet dataSet2 = null;
			if (BackupDataSetBeforeUpdate)
			{
				dataSet2 = new DataSet();
				dataSet2.Merge(dataSet);
			}
			try
			{
				if (_sponsor2TableAdapter != null)
				{
					dictionary.Add(_sponsor2TableAdapter, _sponsor2TableAdapter.Connection);
					_sponsor2TableAdapter.Connection = (SqlConnection)connection;
					_sponsor2TableAdapter.Transaction = (SqlTransaction)dbTransaction;
					if (_sponsor2TableAdapter.Adapter.AcceptChangesDuringUpdate)
					{
						_sponsor2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
						list3.Add(_sponsor2TableAdapter.Adapter);
					}
				}
				if (UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
				{
					num += UpdateUpdatedRows(dataSet, list, list2);
					num += UpdateInsertedRows(dataSet, list2);
				}
				else
				{
					num += UpdateInsertedRows(dataSet, list2);
					num += UpdateUpdatedRows(dataSet, list, list2);
				}
				num += UpdateDeletedRows(dataSet, list);
				dbTransaction.Commit();
				if (0 < list2.Count)
				{
					DataRow[] array = new DataRow[list2.Count];
					list2.CopyTo(array);
					for (int i = 0; i < array.Length; i++)
					{
						array[i].AcceptChanges();
					}
				}
				if (0 < list.Count)
				{
					DataRow[] array2 = new DataRow[list.Count];
					list.CopyTo(array2);
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j].AcceptChanges();
					}
				}
			}
			catch (Exception ex)
			{
				dbTransaction.Rollback();
				if (BackupDataSetBeforeUpdate)
				{
					Debug.Assert(dataSet2 != null);
					dataSet.Clear();
					dataSet.Merge(dataSet2);
				}
				else if (0 < list2.Count)
				{
					DataRow[] array3 = new DataRow[list2.Count];
					list2.CopyTo(array3);
					foreach (DataRow dataRow in array3)
					{
						dataRow.AcceptChanges();
						dataRow.SetAdded();
					}
				}
				throw ex;
			}
			finally
			{
				if (flag)
				{
					connection.Close();
				}
				if (_sponsor2TableAdapter != null)
				{
					_sponsor2TableAdapter.Connection = (SqlConnection)dictionary[_sponsor2TableAdapter];
					_sponsor2TableAdapter.Transaction = null;
				}
				if (0 < list3.Count)
				{
					DataAdapter[] array4 = new DataAdapter[list3.Count];
					list3.CopyTo(array4);
					for (int l = 0; l < array4.Length; l++)
					{
						array4[l].AcceptChangesDuringUpdate = true;
					}
				}
			}
			return num;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
		{
			Array.Sort(rows, new SelfReferenceComparer(relation, childFirst));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
		{
			return _connection != null || Connection == null || inputConnection == null || string.Equals(Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal);
		}
	}
}
