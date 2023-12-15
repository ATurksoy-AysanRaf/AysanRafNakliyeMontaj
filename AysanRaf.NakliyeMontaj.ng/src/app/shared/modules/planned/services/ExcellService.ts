//import {
//  Injectable
//} from '@angular/core';
//import * as FileSaver from 'file-saver';
//import * as XLSX from 'xlsx';
//import * as _ from 'underscore';

//const EXCEL_TYPE = 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8';
//const EXCEL_EXTENSION = '.xlsx';

//@Injectable()
//export class ExcelService {
//  public data: any;
//  public sheetName: string = "Sheet1";
//  public workbook: XLSX.WorkBook = {
//    Sheets: {},
//    SheetNames: [],
//    Props: {}
//  }
//  public ws: any;
//  public wbout: any;

//  constructor() { }

//  public exportAsExcelFile(json: any[], excelFileName: string): void {
//    this.data = json;
//    this.downloadExcel(excelFileName);
//  }

//  public transformData(data: any) {
//    let dataNew: any = [];
//    let keys_arr = [];
//    _.each(data, function (json) {
//      let key: any = json;
//      let arr = _.filter(key, function (val, i) {
//        let value: any = val;
//        let index: any = i;
//        keys_arr.push(index);
//        if (value == 0) {
//          return '0';
//        } else {
//          return value;
//        }
//      });
//      dataNew.push(arr);
//    });
//    dataNew.unshift(_.uniq(keys_arr));
//    return dataNew;
//  }

//  public sheet_from_array_of_arrays(data) {
//    let ws = {};
//    let endCell = {
//      c: 10000000,
//      r: 10000000
//    };
//    let startCell = {
//      c: 0,
//      r: 0
//    };
//    let range = {
//      s: endCell,
//      e: startCell
//    };

//    let wscols = [];

//    for (let R = 0; R != data.length; ++R) {
//      for (let C = 0; C != data[R].length; ++C) {
//        wscols.push({
//          wch: 20
//        });
//        if (range.s.r > R) range.s.r = R;
//        if (range.s.c > C) range.s.c = C;
//        if (range.e.r < R) range.e.r = R;
//        if (range.e.c < C) range.e.c = C;
//        let cell = {
//          v: data[R][C],
//          t: 's',
//          s: {}
//        };

//        if (R === 0) {
//          cell.s = {
//            "font": {
//              "bold": true,
//              "sz": 13,
//              "alignment": {
//                "horizontal": "center",
//                "vertical": "center"
//              }
//            }
//          };
//        }

//        if (cell.v == null) continue;
//        let cell_ref = XLSX.utils.encode_cell({
//          c: C,
//          r: R
//        });
//        if (typeof cell.v === 'number')
//          cell.t = 'n';
//        else if (typeof cell.v === 'boolean')
//          cell.t = 'b';
//        else
//          cell.t = 's';
//        ws[cell_ref] = cell;
//      }
//    }
//    ws['!cols'] = wscols;

//    if (range.s.c < 10000000)
//      ws['!ref'] = XLSX.utils.encode_range(endCell, startCell);

//    return ws;
//  }

//  public generateExcelFile(): any {
//    this.ws = this.sheet_from_array_of_arrays(this.transformData(this.data));
//    this.workbook.SheetNames = [];
//    this.workbook.SheetNames.push(this.sheetName);
//    this.workbook.Sheets[this.sheetName] = this.ws;
//    this.wbout = XLSX.write(this.workbook, {
//      bookType: 'xlsx',
//      type: 'binary'
//    });
//    return this.wbout;
//  }

//  public createView(s: any): ArrayBuffer {
//    let buf = new ArrayBuffer(s.length);
//    let view = new Uint8Array(buf);
//    for (let i = 0; i != s.length; ++i)
//      view[i] = s.charCodeAt(i) & 0xFF;
//    return buf;
//  }

//  public downloadExcel(fileName: string): void {
//    this.sheetName = fileName + '_export_' + new Date().getTime();
//    FileSaver.saveAs(new Blob([this.createView(this.generateExcelFile())], {
//      type: "application/octet-stream"
//    }), fileName + '_export_' + new Date().getTime() + EXCEL_EXTENSION);
//  }
//}
