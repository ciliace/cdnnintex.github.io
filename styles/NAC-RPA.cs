/*#region : Check Radio as Button */
.ntx-custom-menu div.nx-radio:nth-child(1) :has(> input[type=radio]:checked) {
    background-color: rgb(19, 133, 95);
}
.ntx-custom-menu div.nx-radio:nth-child(2) :has(> input[type=radio]:checked) {
    background-color: rgb(255, 176, 0);
}
.ntx-custom-menu div.nx-radio:nth-child(3) :has(> input[type=radio]:checked) {
    background-color: rgb(198, 0, 34);
}
.ntx-custom-menu div.nx-radio:nth-child(4) :has(> input[type=radio]:checked) {
    background-color: rgb(112, 112, 112);
}
[dir] .ntx-custom-menu .nx-radio :has(> input[type=radio]:checked) .nx-radio-label{
    color:#FFF;
}
[dir] .ntx-custom-menu .nx-radio input[type=radio]+.nx-radio-container .nx-radio-faux{
    display: none;
}
[dir] .ntx-custom-menu .nx-radio input[type=radio]+.nx-radio-container{
    padding-left:0px;
    justify-content: center;
}
.ntx-custom-menu div.nx-radio :has(> input[type=radio]) {
    background-color: #f5f5f5;
    color: #000;
    padding: 5px 15px;
    white-space: nowrap;
    font-weight: 500;
    font-size: 16px;
    border: none;
    border-radius: 8px;
    cursor: pointer;
    width: 66px;
}
/*#endregion*/
