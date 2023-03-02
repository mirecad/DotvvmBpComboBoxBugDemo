using System.Collections.Generic;

namespace DotvvmBpComboBoxBugDemo.ViewModels;

public class ComboBoxItemDto
{
    public int Id { get; set; }
    public string Label { get; set; }
}

public class DefaultViewModel : MasterPageViewModel
{
    public ComboBoxItemDto SelectedItem { get; set; }

    public List<ComboBoxItemDto> ComboBoxItems => new()
    {
        new ComboBoxItemDto()
        {
            Id = 1,
            Label = "Item 1"
        },
        new ComboBoxItemDto()
        {
            Id = 2,
            Label = "Item 1"
        }
    };
}