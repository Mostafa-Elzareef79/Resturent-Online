import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SelectedItemsService {
  private selectedItem = 'checkedItems';

  setSelectedItems(data: any) {
    sessionStorage.setItem(this.selectedItem, JSON.stringify(data));
  }

  getSelectedItems() {
    const data = sessionStorage.getItem(this.selectedItem);
    return data ? JSON.parse(data) : null;
  }

}
