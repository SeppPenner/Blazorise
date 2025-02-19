---
title: "Dropdown component"
permalink: /docs/components/dropdown/
excerpt: "Learn how to use dropdowns."
toc: true
toc_label: "Guide"
---

## Basics

The dropdown component is a container for a dropdown button and a dropdown menu.

- `Dropdown` the **main** container
  - `DropdownToggle` toggle button
  - `DropdownMenu` the toggable menu, **hidden** by default
    - `DropdownItem` each **single** item of the dropdown menu
    - `DropdownDivider` a **horizontal line** to separate dropdown items
          

## Dropdown

```html
<Dropdown>
    <DropdownToggle Color="Color.Primary">
        Dropdown
    </DropdownToggle>
    <DropdownMenu>
        <DropdownItem>Action</DropdownItem>
        <DropdownDivider />
        <DropdownItem>Another Action</DropdownItem>
    </DropdownMenu>
</Dropdown>
```

<iframe src="/examples/buttons/dropdown/" frameborder="0" scrolling="no" style="width:100%;height:150px;"></iframe>

### Split dropdown

Just add another `Button` to have a split dropdown.

```html
<Dropdown>
    <SimpleButton>Split Dropdown</SimpleButton>
    <DropdownToggle IsSplit="true"/>
    <DropdownMenu>
        <DropdownItem>Action</DropdownItem>
        <DropdownDivider />
        <DropdownItem>Another Action</DropdownItem>
    </DropdownMenu>
</Dropdown>
```

<iframe src="/examples/buttons/splitdropdown/" frameborder="0" scrolling="no" style="width:100%;height:150px;"></iframe>

## Usage

By default a dropdown toggle will open and close a dropdown menu without the need to do it manually. In case you need to control the menu programatically you have to use the Dropdown reference.

```html
<Dropdown @ref="dropdown">
    <DropdownToggle />
    <DropdownMenu>
        ...
    </DropdownMenu>
</Dropdown>

<SimpleButton Clicked="@ShowMenu">Show Menu</SimpleButton>
```

```cs
@code{
    Dropdown dropdown;

    void ShowMenu()
    {
        dropdown.Open();
    }
}
```

## Functions

| Name         | Description                                                                                 |
|--------------|---------------------------------------------------------------------------------------------|
| Open()       | Open the dropdown menu.                                                                     |
| Close()      | Close the dropdown menu.                                                                    |
| Toggle()     | Switches the visibility of dropdown menu.                                                   |

## Attributes

### Dropdown

| Name           | Type                                                                   | Default   | Description                                                                                                                    |
|----------------|------------------------------------------------------------------------|-----------|--------------------------------------------------------------------------------------------------------------------------------|
| IsOpen         | boolean                                                                | false     | Handles the visibility of dropdown menu.                                                                                       |
| IsRightAligned | boolean                                                                | false     | Right aligned dropdown menu.                                                                                                   |
| Direction      | [Direction]({{ "/docs/helpers/enums/#direction" | relative_url }})     | `Down`    | Direction of an dropdown menu.                                                                                                 |
| Toggled        | event                                                                  |           | Occurs after the dropdown menu visibility has changed.                                                                         |

### DropdownMenu

| Name           | Type                                                                   | Default   | Description                                                                                                                    |
|----------------|------------------------------------------------------------------------|-----------|--------------------------------------------------------------------------------------------------------------------------------|
| IsRightAligned | boolean                                                                | false     | Right aligned dropdown menu.                                                                                                   |

### DropdownItem

| Name           | Type                                                                   | Default   | Description                                                                                                                    |
|----------------|------------------------------------------------------------------------|-----------|--------------------------------------------------------------------------------------------------------------------------------|
| Value          | object                                                                 | null      | Holds the item value.                                                                                                          |
| Clicked        | event                                                                  |           | Occurs when the item is clicked.                                                                                               |

### DropdownToggle

| Name           | Type                                                                   | Default   | Description                                                                                                                    |
|----------------|------------------------------------------------------------------------|-----------|--------------------------------------------------------------------------------------------------------------------------------|
| Color          | [Colors]({{ "/docs/helpers/colors/#color" | relative_url }})           | `None`    | Component visual or contextual style variants.                                                                                 |
| Size           | [ButtonSize]({{ "/docs/helpers/sizes/#buttonsize" | relative_url }})   | `None`    | Button size variations.                                                                                                        |
| IsSplit        | boolean                                                                | false     | Handles the visibility of split button.                                                                                        |
| IsOutline      | boolean                                                                | false     | Outlined button                                                                                                                |