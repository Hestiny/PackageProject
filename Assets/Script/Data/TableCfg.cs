
namespace TableDataConfig
{
    //====不要手动修改 会被覆盖====
    //不依赖任何游戏逻辑 在所有数据和逻辑加载前加载 默认懒加载
    public class TableCfg
    {
        private TestDataConfig _testData;        public TestDataConfig testData        {            get { return _testData ??= new TestDataConfig(); }            set => _testData = value;        }        
        /// <summary>
        /// 饥饿加载
        /// ====不要手动修改 会被覆盖====
        /// </summary>
        public void Init()
        {

        }
        
        public TableCfg()
        {
            Init();
        }

        /// <summary>
        /// 懒加载
        /// </summary>
        public void InitLazy()
        {
        }
       
    }
}