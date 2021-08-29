namespace bing
{
    public  class bo
    {
        
    }
    DataTable configinfotype;

    string all = this.cbxAffiliatedProject.SelectedValue.ToString();
    DataRow[] newRow;

    newRow = configinfotype.Select("ProductID=" + all);//查询所属项目为当前选择的产品
    AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
    foreach (DataRow row in newRow)//添加到提示数据中
    {
    ac.Add(row["ProductName"].ToString());
    }

    this.txtFittingsName.AutoCompleteSource = AutoCompleteSource.CustomSource;
    this.txtFittingsName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
    this.txtFittingsName.AutoCompleteCustomSource = ac;

    //configinfotype中存的是从数据库中检索出来的所有记录，可以换成自己查询出来的内容。ProductID和ProductName是检索出来的表中的两个列
}