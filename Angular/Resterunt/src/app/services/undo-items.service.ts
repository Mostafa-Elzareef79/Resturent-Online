import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UndoItemsService {

  private selectedRestrunt = 'restruntId';

  setSelectedRestrunt(data: any) {
    sessionStorage.setItem(this.selectedRestrunt, JSON.stringify(data));
  }

  getSelectedRestrunt() {
    const data = sessionStorage.getItem(this.selectedRestrunt);
    return data ? JSON.parse(data) : null;
  }
}
