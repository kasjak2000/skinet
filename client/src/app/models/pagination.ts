// Pagination can be used for many thing, so it gets the type T
export interface Pagination<T> {
    pageIndex: number;
    pageSize: number;
    count: number;
    data: T;
}