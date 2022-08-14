namespace Aggregator.Data
{
    public class OrdersSimulatorService
    {
        private static readonly string[] From = new[]
        {
            "���������� �����, ��2", "���������� �������, 24", "����������� �����, 7�3", "������� ��������� �����, 1��6", "��������������� �����., 24�", "��������� �����, 6�1", "��������� �����, 7�", "����� �������, 15�1", "�������� �����, 23�5", "����� ��������� �����, 1�1"
        };
        private static readonly string[] FromYandex = new[]
        {
            "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.594051%2C55.660093&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.585382%2C55.659851&whatshere%5Bzoom%5D=15&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">���������� �����, ��2 �� ����� ������, ��������� ����� ������ � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHDdcC\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.594051%2C55.660093&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.602634%2C55.653591&whatshere%5Bzoom%5D=15&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">���������� �������, 24 �� ����� ������, ��������� ����� ��������� � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHDeOC\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.594051%2C55.660093&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.580275%2C55.656988&whatshere%5Bzoom%5D=15&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">����������� �����, 7�3 �� ����� ������, ��������� ����� ������ � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHwr0A\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.594051%2C55.660093&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.595296%2C55.650218&whatshere%5Bzoom%5D=15&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">������� ��������� �����, 1��6 �� ����� ������, ��������� ����� ��������� � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHs0xA\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/org/tsentr_planirovaniya_semyi_i_reproduktsii/150956088373/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">����� ������������ ����� � �����������</a><a href=\"https://yandex.ru/maps/213/moscow/category/maternity_home/184106016/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">��������� ��� � ������</a><a href=\"https://yandex.ru/maps/213/moscow/category/women_health/184106010/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:28px;\">������� ������������ � ������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHgdcA\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.594051%2C55.660093&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.600488%2C55.662349&whatshere%5Bzoom%5D=15&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">��������� �����, 6�1 �� ����� ������, ��������� ����� ����������� �������� � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHgQWD\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.594051%2C55.660093&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.604050%2C55.658710&whatshere%5Bzoom%5D=15&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">��������� �����, 7� �� ����� ������, ��������� ����� ����������� �������� � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHWHCB\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.594051%2C55.660093&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.582850%2C55.652062&whatshere%5Bzoom%5D=15&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">����� �������, 15�1 �� ����� ������, ��������� ����� ������ � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHSlPC\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.594051%2C55.660093&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.595253%2C55.656308&whatshere%5Bzoom%5D=15&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">�������� �����, 23�5 �� ����� ������, ��������� ����� ��������� � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHGD2A\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.594051%2C55.660093&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.593879%2C55.653882&whatshere%5Bzoom%5D=15&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">����� ��������� �����, 1�1 �� ����� ������, ��������� ����� ��������� � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHCXsA\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>","<div style=\"position:relative;overflow:hidden;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?bookmarks%5Bpid%5D=home&bookmarks%5Buri%5D=ymapsbm1%3A%2F%2Fpin%3Fll%3D37.587582%252C55.655518&ll=37.594051%2C55.660093&utm_medium=mapframe&utm_source=maps&z=15\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">��� � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHTEHC\" width=\"560\" height=\"400\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>"
        };
        private static readonly string[] To = new[]
        {
            "����� ����������, 25", "������������� �����, 18�2", "����������� ����������, 52�", "����� ��������� ���., 8", "�������� ����������, 2/1�1", "��������� �����, 21", "����� �������, 14�3", "����� ������� ���������, 1/30", "����� �������, 14", "������ ��������, 3"
        };
        private static readonly string[] ToYandex = new[]
        {
            "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.664029%2C55.726864&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.667194%2C55.725199&whatshere%5Bzoom%5D=17&z=17\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">����� ����������, 25 � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHRS9B\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.646706%2C55.730319&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.647725%2C55.728490&whatshere%5Bzoom%5D=17&z=17\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">������������� �����, 18�2 � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHFW3D\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.635795%2C55.734938&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.639958%2C55.733812&whatshere%5Bzoom%5D=17&z=17\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">����������� ����������, 52� � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHB0xB\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/org/tatarskiy_kulturny_tsentr/1101421364/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">��������� ���������� �����</a><a href=\"https://yandex.ru/maps/213/moscow/category/cultural_center/184105880/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">���������� ����� � ������</a><a href=\"https://yandex.ru/maps/213/moscow/category/community_organization/184106274/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:28px;\">������������ ����������� � ������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHu0XB\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.638297%2C55.732214&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.641794%2C55.731971&whatshere%5Bzoom%5D=16&z=16\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">�������� ����������, 2/1�1 � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHq81B\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.645163%2C55.743073&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.649433%2C55.743811&whatshere%5Bzoom%5D=16&z=16\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">��������� �����, 21 � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHe18D\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.631838%2C55.747588&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.640078%2C55.752005&whatshere%5Bzoom%5D=16&z=16\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">����� �������, 14�3 � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHa33B\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.622504%2C55.753215&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.616539%2C55.758878&whatshere%5Bzoom%5D=16&z=16\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">����� ������� ���������, 1/30 � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHUxLD\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.622504%2C55.753215&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.629993%2C55.755865&whatshere%5Bzoom%5D=16&z=16\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">����� �������, 14 � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHQ~PD\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>", "<div style=\"position:relative;overflow:hidden;height:30rem;\"><a href=\"https://yandex.ru/maps/213/moscow/?utm_medium=mapframe&utm_source=maps\" style=\"color:#eee;font-size:12px;position:absolute;top:0px;\">������</a><a href=\"https://yandex.ru/maps/213/moscow/?ll=37.622504%2C55.753215&mode=whatshere&utm_medium=mapframe&utm_source=maps&whatshere%5Bpoint%5D=37.627890%2C55.753300&whatshere%5Bzoom%5D=16&z=16\" style=\"color:#eee;font-size:12px;position:absolute;top:14px;\">������ ��������, 3 � �����������</a><iframe src=\"https://yandex.ru/map-widget/v1/-/CCURRHAPcB\" class=\"w-100 h-100\" frameborder=\"1\" allowfullscreen=\"true\" style=\"position:relative;\"></iframe></div>"
        };

        public Task<OrdersSimulator[]> GetSimulatorAsync(string filter)
        {
            generator[] gen=(Enumerable.Range(1, Random.Shared.Next(3, 10)).Select(index => new generator
            {
                Id = index,
                From = Random.Shared.Next(10),
                To = Random.Shared.Next(10)
            }).ToArray());
            return Task.FromResult(gen.Select(g => new OrdersSimulator
            {
                Id = g.Id,
                From = From[g.From],
                FromYandex = FromYandex[g.From],
                To = To[g.To],
                ToYandex = ToYandex[g.To]
            }).Where(a=>a.From.Contains(filter) || a.To.Contains(filter)).ToArray());
        }
        private class generator
        {
            public int Id { get; set; }
            public int From { get; set; }
            public int To { get; set; }
        }
    }
}