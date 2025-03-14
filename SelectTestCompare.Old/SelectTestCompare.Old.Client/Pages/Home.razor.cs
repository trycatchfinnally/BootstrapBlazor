// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License
// See the LICENSE file in the project root for more information.
// Maintainer: Argo Zhang(argo@live.ca) Website: https://www.blazor.zone

using BootstrapBlazor.Components;

namespace SelectTestCompare.Old.Client.Pages;

partial class Home
{
    private string? selectValue = null;
    private string selectNotNullValue = "10";
    private int selectValueInt = 100;
    private int? selectValueIntNull = 1000;

    private string? bindQueryValue;
    private static readonly SelectedItem[] s_Items1 = Enumerable.Range(1, 5)
        .Select(i => new SelectedItem(i.ToString(), $"选项{i}"))
        .ToArray();
    private static readonly SelectedItem[] s_Items2 = Enumerable.Range(10, 5)
      .Select(i => new SelectedItem(i.ToString(), $"选项{i}"))
      .ToArray();
    private static readonly SelectedItem[] s_Items3 = Enumerable.Range(100, 5)
      .Select(i => new SelectedItem(i.ToString(), $"选项{i}"))
      .ToArray();
    private static readonly SelectedItem[] s_Items4 = Enumerable.Range(1000, 5)
      .Select(i => new SelectedItem(i.ToString(), $"选项{i}"))
      .ToArray();


    private Task<QueryData<SelectedItem>> OnQueryAsync(VirtualizeQueryOption virtualizeQueryOption)
    {
        return Task.FromResult(new QueryData<SelectedItem>
        {
            TotalCount = 5,
            Items = Enumerable.Range(10000, 5)
      .Select(i => new SelectedItem(i.ToString(), $"选项{i}"))
      .ToArray()
        });
    }

}
