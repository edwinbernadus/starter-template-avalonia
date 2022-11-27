# starter-template-avalonia

## Getting Started
** read this first **  
https://github.com/edwinbernadus/starter-template-frontend-framework

## Getting Started
https://github.com/edwinbernadus/first-interaction-frontend-framework


## Snippet List
- hint_create_button
````csharp
<!-- // hint_create_button -->
<Button Width="160" Command="{Binding OnClickCommand}">Go To Detail Button </Button>
````
- hint_open_new_page
````csharp
// hint_open_new_page
var result = await dialog.ShowDialog<MvListPage>(this);
````
- hint_loading_webservice
````csharp
// hint_loading_webservice
var url = "https://jsonplaceholder.typicode.com/albums";
var content = await httpClient.GetStringAsync(url);
var items = JsonConvert.DeserializeObject<List<PlaceHolderItem>>(content);
````
- hint_show_loading_indicator
````csharp
// hint_show_loading_indicator
this.IsVisibleLoading = true;
this.IsVisibleContent = false;
````
- hint_show_webservice_result_on_list
````csharp
<!-- // hint_show_webservice_result_on_list -->
<ItemsControl Items="{Binding Items}" IsVisible="{Binding IsVisibleContent,Mode=TwoWay}">
    <ItemsControl.ItemTemplate>
        <DataTemplate>
            <StackPanel>
                <TextBlock Text="{Binding title}" />
                <Button Width="160" Command="{Binding OnInfoClickCommand}">Info</Button>
            </StackPanel>
        </DataTemplate>
    </ItemsControl.ItemTemplate>
</ItemsControl>
````
- hint_button_on_list
````csharp
<!-- //hint_button_on_list -->
<Button Width="160" Command="{Binding OnInfoClickCommand}">Info</Button>
````
- hint_show_detail_item_on_alert
````csharp
// hint_show_detail_item_on_alert
this.Parent.DisplayInfoAlert = $"{id}-{title}";
````