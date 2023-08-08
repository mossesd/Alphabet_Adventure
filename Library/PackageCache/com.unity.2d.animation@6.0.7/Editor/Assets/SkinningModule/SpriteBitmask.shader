MasterPreviewView {
    flex-direction: column;
    position: absolute;
    right: 10px;
    bottom: 10px;
    width: 125px;
    height: 125px;
    min-width: 100px;
    min-height: 100px;
    background-color: rgb(79, 79, 79);
    justify-content: flex-start;
    border-radius: 6px;
    border-top-width: 1px;
    border-bottom-width: 1px;
    border-left-width: 1px;
    border-right-width: 1px;
    border-color: rgb(25,25,25);
}

MasterPreviewView > #top {
    flex-direction: row;
    justify-content: space-between;
    background-color: rgb(64, 64, 64);
    padding: 8px;
    border-top-left-radius: 6px;
    border-top-right-radius: 6px;
}

MasterPreviewView > #top > #title {
    overflow: hidden;
    font-size: 14px;
    color: rgb(180, 180, 180);
    padding: 1px 2px 2px;
}

MasterPreviewView > #middle {
    background-color: rgb(49, 49, 49);
    flex-grow: 1;
    flex-direction: row;
}

MasterPreviewView > #middle > #preview {
    flex-grow: 1;
    width: 100px;
    height: 100px;
}
                                                                                                                                               