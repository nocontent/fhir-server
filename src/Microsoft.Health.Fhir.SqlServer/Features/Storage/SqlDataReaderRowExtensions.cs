﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Data.SqlClient;

namespace Microsoft.Health.Fhir.SqlServer.Features.Schema.Model
{
    /// <summary>
    /// Extensions on <see cref="SqlDataReader"/> for reading an entire data row based on
    /// <see cref="Column{T}"/> definitions for strong typing.
    /// </summary>
    public static class SqlDataReaderRowExtensions
    {
        public static T0 ReadRow<T0>(
            this SqlDataReader reader,
            Column<T0> column0)
        {
            return reader.Read(column0, 0);
        }

        public static (T0, T1) ReadRow<T0, T1>(
            this SqlDataReader reader,
            Column<T0> column0,
            Column<T1> column1)
        {
            return (
                reader.Read(column0, 0),
                reader.Read(column1, 1));
        }

        public static (T0, T1, T2) ReadRow<T0, T1, T2>(
            this SqlDataReader reader,
            Column<T0> column0,
            Column<T1> column1,
            Column<T2> column2)
        {
            return (
                reader.Read(column0, 0),
                reader.Read(column1, 1),
                reader.Read(column2, 2));
        }

        public static (T0, T1, T2, T3) ReadRow<T0, T1, T2, T3>(
            this SqlDataReader reader,
            Column<T0> column0,
            Column<T1> column1,
            Column<T2> column2,
            Column<T3> column3)
        {
            return (
                reader.Read(column0, 0),
                reader.Read(column1, 1),
                reader.Read(column2, 2),
                reader.Read(column3, 3));
        }

        public static (T0, T1, T2, T3, T4) ReadRow<T0, T1, T2, T3, T4>(
            this SqlDataReader reader,
            Column<T0> column0,
            Column<T1> column1,
            Column<T2> column2,
            Column<T3> column3,
            Column<T4> column4)
        {
            return (
                reader.Read(column0, 0),
                reader.Read(column1, 1),
                reader.Read(column2, 2),
                reader.Read(column3, 3),
                reader.Read(column4, 4));
        }

        public static (T0, T1, T2, T3, T4, T5) ReadRow<T0, T1, T2, T3, T4, T5>(
            this SqlDataReader reader,
            Column<T0> column0,
            Column<T1> column1,
            Column<T2> column2,
            Column<T3> column3,
            Column<T4> column4,
            Column<T5> column5)
        {
            return (
                reader.Read(column0, 0),
                reader.Read(column1, 1),
                reader.Read(column2, 2),
                reader.Read(column3, 3),
                reader.Read(column4, 4),
                reader.Read(column5, 5));
        }

        public static T Read<T>(this SqlDataReader reader, Column<T> column, int ordinal)
        {
            return column.Read(reader, ordinal);
        }
    }
}
