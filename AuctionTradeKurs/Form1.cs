using Npgsql;
using System.Data;
using System.Windows.Forms;
using Xceed.Words.NET;
using Xceed.Document.NET;
using NpgsqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AuctionTradeKurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridViewAuction.Columns.Add("AuctioneerId", "�����������");
            dataGridViewAuction.Columns.Add("PlaceId", "�����");
            dataGridViewAuction.Columns.Add("FormId", "����� ����������");
            dataGridViewAuction.Columns.Add("StartDateTime", "���� ������");
            dataGridViewAuction.Columns.Add("EndDateTime", "���� ���������");
            dataGridViewAuction.Columns.Add("Status", "������");

            LoadAuctionsIntoDataGridView();
        }

        private string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=auction_trade";

        private void ��������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewAuction.Visible = true;
            dataGridViewLot.Visible = false;
            dataGridViewLog.Visible = false;
            dataGridView4.Visible = false;

            dataGridViewAuction.DataSource = null;
            dataGridViewAuction.Columns.Clear();

            dataGridViewAuction.Columns.Add("AuctioneerId", "�����������");
            dataGridViewAuction.Columns.Add("PlaceId", "�����");
            dataGridViewAuction.Columns.Add("FormId", "����� ����������");
            dataGridViewAuction.Columns.Add("StartDateTime", "���� ������");
            dataGridViewAuction.Columns.Add("EndDateTime", "���� ���������");
            dataGridViewAuction.Columns.Add("Status", "������");

            LoadAuctionsIntoDataGridView();

            label1.Text = "���� � ����� ������ ��������";
            label2.Text = "���� � ����� ��������� ��������";
            label3.Text = "������� ����������";
            label4.Text = "������� ����� ����������";
            label5.Text = "������� ����� ����������";

            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = false;

            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = false;
            label4.Visible = true;
            textBox4.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = false;
            comboBox5.Visible = false;


            dataGridViewAuction.Width = 644;
            dataGridViewAuction.Height = 242;
            dataGridViewLog.Height = 242;

            dataGridViewAuction.Location = new Point(12, 195);
            dataGridViewLog.Location = new Point(335, 195);

            dataGridViewLog.Visible = false;
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewAuction.Visible = false;
            dataGridViewLot.Visible = true;
            dataGridViewLog.Visible = false;
            dataGridView4.Visible = false;

            dataGridViewLot.DataSource = null;
            dataGridViewLot.Columns.Clear();

            dataGridViewLot.Columns.Add("LotName", "�������� ����");
            dataGridViewLot.Columns.Add("CategoryName", "��������� ����");
            dataGridViewLot.Columns.Add("StartPrice", "��������� ����");
            dataGridViewLot.Columns.Add("CurrentPrice", "������� ����");
            dataGridViewLot.Columns.Add("Status", "������");
            dataGridViewLot.Columns.Add("SellerName", "��������");
            dataGridViewLot.Columns.Add("BuyerName", "����������");
            dataGridViewLot.Columns.Add("BidCount", "���������� ������");
            dataGridViewLot.Columns.Add("FinalPrice", "��������� ����");

            LoadBuyersIntoComboBox();
            LoadCategoriesIntoComboBox();
            LoadLotsIntoDataGridView();

            label1.Text = "��������� ����";
            label2.Text = "�������� ����";
            label3.Text = "��������� ���� ����";
            label4.Text = "�������� ����";

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;

            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;


            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = true;
            comboBox5.Visible = true;

            dataGridViewAuction.Width = 644;
            dataGridViewAuction.Height = 242;
            dataGridViewLog.Height = 242;

            dataGridViewAuction.Location = new Point(12, 195);
            dataGridViewLog.Location = new Point(335, 195);

            dataGridViewLog.Visible = false;
        }

        private void �������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridViewAuction.DataSource = null;

            dataGridViewAuction.Visible = false;
            dataGridViewLot.Visible = false;
            dataGridViewLog.Visible = true;
            dataGridView4.Visible = true;

            dataGridView4.DataSource = null;
            dataGridViewLog.DataSource = null;
            dataGridView4.Columns.Clear();
            dataGridViewLog.Columns.Clear();

            dataGridViewLog.Columns.Add("participant", "�������� ��������");
            dataGridViewLog.Columns.Add("action", "������");
            dataGridViewLog.Columns.Add("action_datetime", "����� ��������");

            //dataGridView4.Columns.Add("LotName", "���");
            //dataGridView4.Columns.Add("BuyerName", "����������");
            //dataGridView4.Columns.Add("FinalPrice", "����");
            
            LoadBidsIntoDataGridViewLog();
            //LoadSoldLotsIntoDataGridView();

            dataGridView4.Columns.Add("LotName", "���");
            dataGridView4.Columns.Add("BuyerName", "����������");
            dataGridView4.Columns.Add("FinalPrice", "������������� ����");
            dataGridView4.Columns.Add("AuctionEndTime", "����� ���������� ��������");
            dataGridView4.Columns.Add("PaymentDateTime", "����� ������");
            dataGridView4.Columns.Add("PaymentStatus", "������ ������");


            LoadAuctionPaymentInfoIntoDataGridView4();

            label1.Text = "�������� ����";
            label2.Text = "�������� ����";
            label3.Text = "��������� ���� ����";

            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;

            label1.Visible = false;
            textBox1.Visible = false;            
            label2.Visible = false;
            textBox2.Visible = false;            
            label3.Visible = false;
            textBox3.Visible = false;            
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = true;


            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;

            //dataGridView.Width = 317;
            //dataGridViewAuction.Height = 410;
            dataGridViewLog.Height = 160;
            dataGridViewLog.Width = 644;

            dataGridViewAuction.Location = new Point(12, 27);
            dataGridViewLog.Location = new Point(12, 42);

            button1.Location = new Point(662, 27);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            /*DialogResult dr = MessageBox.Show("�� �������, ��� ������ ������� ����������?", "�����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)*/

            Application.Exit();
        }
        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form helpF = new HelpForm();
            helpF.ShowDialog();

            //MessageBox.Show("���� � ����� ���������� ������� � �������: 2025-01-01 12:00:00.\n", "������", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutF = new AboutForm();
            aboutF.ShowDialog();

            //MessageBox.Show("����� ���������: ������ ������� �������������, ������ 606-11.\n\n��������� ������������� ��� ���������� ����������, ������, �������������� � ��������.", "�������", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        //������ ������������ �����
        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = $@"C:\Users\Lenovo\source\repos\AuctionTradeKurs\Report{DateTime.Now:dd.MM.yyyy}.docx";

            try
            {
                var doc = DocX.Create(fileName);

                // ��������� ������
                string title = $"����� �� ��������� �� {DateTime.Now:dd.MM.yyyy HH:mm}";
                doc.InsertParagraph($"{title}\n");

                // ��������� ������ � ��������� ����������
                var bids = GetBidsFromDatabase();

                // �������� ������ ������� � ���������
                var table1 = doc.AddTable(bids.Count + 1, 3);
                table1.Alignment = Alignment.center;
                table1.Design = TableDesign.LightGrid;

                // ���������� ���������� ������ �������
                table1.Rows[0].Cells[0].Paragraphs.First().Append("�������� ��������").Bold().Alignment = Alignment.center;
                table1.Rows[0].Cells[1].Paragraphs.First().Append("��������").Bold().Alignment = Alignment.center;
                table1.Rows[0].Cells[2].Paragraphs.First().Append("����� ��������").Bold().Alignment = Alignment.center;

                // ���������� ������ � ������ �������
                for (int i = 0; i < bids.Count; i++)
                {
                    table1.Rows[i + 1].Cells[0].Paragraphs.First().Append(bids[i].Participant);
                    table1.Rows[i + 1].Cells[1].Paragraphs.First().Append(bids[i].Action);
                    table1.Rows[i + 1].Cells[2].Paragraphs.First().Append(bids[i].ActionDateTime.ToString("dd.MM.yyyy HH:mm"));
                }

                // ��������� ������ � ��������� ����� � �������������� �����������
                var auctionPaymentInfos = GetAuctionPaymentInfoFromDatabase();

                // �������� ����� ������� � ���������
                var table2 = doc.AddTable(auctionPaymentInfos.Count + 1, 6);
                table2.Alignment = Alignment.center;
                table2.Design = TableDesign.LightGrid;

                // ���������� ���������� ����� �������
                table2.Rows[0].Cells[0].Paragraphs.First().Append("���").Bold().Alignment = Alignment.center;
                table2.Rows[0].Cells[1].Paragraphs.First().Append("����������").Bold().Alignment = Alignment.center;
                table2.Rows[0].Cells[2].Paragraphs.First().Append("��������� ����").Bold().Alignment = Alignment.center;
                table2.Rows[0].Cells[3].Paragraphs.First().Append("����� ���������� ��������").Bold().Alignment = Alignment.center;
                table2.Rows[0].Cells[4].Paragraphs.First().Append("����� ������").Bold().Alignment = Alignment.center;
                table2.Rows[0].Cells[5].Paragraphs.First().Append("������ ������").Bold().Alignment = Alignment.center;

                // ���������� ������ � ����� �������
                for (int i = 0; i < auctionPaymentInfos.Count; i++)
                {
                    table2.Rows[i + 1].Cells[0].Paragraphs.First().Append(auctionPaymentInfos[i].LotName);
                    table2.Rows[i + 1].Cells[1].Paragraphs.First().Append(auctionPaymentInfos[i].BuyerName);
                    table2.Rows[i + 1].Cells[2].Paragraphs.First().Append(auctionPaymentInfos[i].FinalPrice.ToString("N2"));
                    table2.Rows[i + 1].Cells[3].Paragraphs.First().Append(auctionPaymentInfos[i].AuctionEndTime.ToString("dd.MM.yyyy HH:mm"));
                    table2.Rows[i + 1].Cells[4].Paragraphs.First().Append(auctionPaymentInfos[i].PaymentDateTime.ToString("dd.MM.yyyy HH:mm"));
                    table2.Rows[i + 1].Cells[5].Paragraphs.First().Append(auctionPaymentInfos[i].PaymentStatus);
                }

                doc.InsertTable(table1);
                doc.InsertParagraph("\n"); // ���������� ������ ������ ����� ���������
                doc.InsertTable(table2);

                doc.Save();

                MessageBox.Show("����� �����������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ������������ ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<BidLog> GetBidsFromDatabase()
        {
            var bids = new List<BidLog>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(@"
            SELECT
                participant,
                action,
                action_datetime
            FROM
                bid_log;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bids.Add(new BidLog
                            {
                                Participant = reader.GetString(reader.GetOrdinal("participant")),
                                Action = reader.GetString(reader.GetOrdinal("action")),
                                ActionDateTime = reader.GetDateTime(reader.GetOrdinal("action_datetime"))
                            });
                        }
                    }
                }
            }
            return bids;
        }

        private void LoadBidsIntoDataGridViewLog()
        {
            var bids = GetBidsFromDatabase();

            dataGridViewLog.Rows.Clear(); // ������� DataGridView ����� ����������� ����� ������

            foreach (var bid in bids)
            {
                dataGridViewLog.Rows.Add(
                    bid.Participant,
                    bid.Action,
                    bid.ActionDateTime.ToString("dd.MM.yyyy HH:mm")
                );
            }
        }

        private List<SoldLot> GetSoldLotsFromDatabase()
        {
            var soldLots = new List<SoldLot>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(@"
            SELECT
                l.lot_name,
                c.username AS buyer_name,
                l.final_price
            FROM
                lot l
            JOIN
                client c ON l.buyer_id = c.client_id
            WHERE
                l.status = '�������';", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            soldLots.Add(new SoldLot
                            {
                                LotName = reader.GetString(reader.GetOrdinal("lot_name")),
                                BuyerName = reader.GetString(reader.GetOrdinal("buyer_name")),
                                FinalPrice = reader.GetDecimal(reader.GetOrdinal("final_price"))
                            });
                        }
                    }
                }
            }
            return soldLots;
        }

        // ������ ��������� �������
        private void button2_Click(object sender, EventArgs e)
        {
            string start = textBox1.Text;
            string end = textBox2.Text;
            string formType = comboBox1.SelectedItem?.ToString();
            string placeAddress = comboBox2.SelectedItem?.ToString();
            string auctioneerUsername = comboBox3.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(start) || string.IsNullOrWhiteSpace(end) || string.IsNullOrWhiteSpace(formType) || string.IsNullOrWhiteSpace(placeAddress) || string.IsNullOrWhiteSpace(auctioneerUsername))
            {
                MessageBox.Show("����������, ������� ��� ������ � �������� ��� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(start, out DateTime startDateTime))
            {
                MessageBox.Show("������������ ������ ����/������� ������ ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(end, out DateTime endDateTime))
            {
                MessageBox.Show("������������ ������ ����/������� ��������� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int formId = GetFormIdByType(formType);
            int placeId = GetPlaceIdByAddress(placeAddress);
            int auctioneerId = GetAuctioneerIdByUsername(auctioneerUsername);

            if (formId == -1 || placeId == -1 || auctioneerId == -1)
            {
                MessageBox.Show("�� ������� ���������� ���� �� ���������� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO auction (start_datetime, end_datetime, form_id, place_id, auctioneer_id) VALUES (@start, @end, @formId, @placeId, @auctioneerId)";

                using (var cmd = new NpgsqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("start", NpgsqlDbType.Timestamp) { Value = startDateTime });
                    cmd.Parameters.Add(new NpgsqlParameter("end", NpgsqlDbType.Timestamp) { Value = endDateTime });
                    cmd.Parameters.Add(new NpgsqlParameter("formId", NpgsqlDbType.Integer) { Value = formId });
                    cmd.Parameters.Add(new NpgsqlParameter("placeId", NpgsqlDbType.Integer) { Value = placeId });
                    cmd.Parameters.Add(new NpgsqlParameter("auctioneerId", NpgsqlDbType.Integer) { Value = auctioneerId });

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("������ ������� ��������� � ���������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int GetFormIdByType(string formType)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT form_id FROM form WHERE form_type = @formType";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("formType", formType);
                    var result = cmd.ExecuteScalar();

                    return result != DBNull.Value ? (int)result : -1;
                }
            }
        }

        private int GetPlaceIdByAddress(string address)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT place_id FROM place WHERE address = @address";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("address", address);
                    var result = cmd.ExecuteScalar();

                    return result != DBNull.Value ? (int)result : -1;
                }
            }
        }

        private int GetAuctioneerIdByUsername(string username)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT auctioneer_id FROM auctioneer WHERE username = @username";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    var result = cmd.ExecuteScalar();

                    return result != DBNull.Value ? (int)result : -1;
                }
            }
        }

        private List<Auction> GetAuctionsFromDatabase()
        {
            var auctions = new List<Auction>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(@"
            SELECT
                a.auction_id,
                e.username AS auctioneer_name,
                p.address AS place_address,
                f.form_type AS form,
                a.start_datetime,
                a.end_datetime,
                a.status
            FROM
                auction a
            JOIN
                auctioneer e ON a.auctioneer_id = e.auctioneer_id
            JOIN
                form f ON a.form_id = f.form_id
            JOIN
                place p ON a.place_id = p.place_id;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var auction = new Auction
                            {
                                Auctioneer = reader.IsDBNull(reader.GetOrdinal("auctioneer_name")) ? string.Empty : reader.GetString(reader.GetOrdinal("auctioneer_name")),
                                Place = reader.IsDBNull(reader.GetOrdinal("place_address")) ? string.Empty : reader.GetString(reader.GetOrdinal("place_address")),
                                Form = reader.IsDBNull(reader.GetOrdinal("form")) ? string.Empty : reader.GetString(reader.GetOrdinal("form")),
                                StartDateTime = reader.IsDBNull(reader.GetOrdinal("start_datetime")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("start_datetime")),
                                EndDateTime = reader.IsDBNull(reader.GetOrdinal("end_datetime")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("end_datetime"))
                            };

                            if (auction.EndDateTime < DateTime.Now)
                            {
                                auction.Status = "�������";
                            }
                            else if (auction.StartDateTime <= DateTime.Now && auction.EndDateTime >= DateTime.Now)
                            {
                                auction.Status = "����������";
                            }
                            else
                            {
                                auction.Status = "���������";
                            }

                            auctions.Add(auction);
                        }
                    }
                }
            }
            return auctions;
        }

        private void LoadAuctionsIntoDataGridView()
        {
            var auctions = GetAuctionsFromDatabase();

            //dataGridViewAuction.DataSource = null;

            foreach (var auction in auctions)
            {
                dataGridViewAuction.Rows.Add(
                    //auction.AuctionId,
                    auction.Auctioneer,
                    auction.Place,
                    auction.Form,
                    auction.StartDateTime.ToString("dd.MM.yyyy HH:mm"),
                    auction.EndDateTime.ToString("dd.MM.yyyy HH:mm"),
                    auction.Status
                );
            }
        }

        //������ �������� ���
        private void button3_Click(object sender, EventArgs e)
        {
            string lotname = textBox2.Text;
            decimal startPrice = decimal.Parse(textBox3.Text);
            string categoryName = comboBox5.SelectedItem?.ToString();
            int sellerId = GetClientIdByUsername(comboBox4.SelectedItem?.ToString());

            if (string.IsNullOrWhiteSpace(lotname) || string.IsNullOrWhiteSpace(categoryName) || sellerId == -1)
            {
                MessageBox.Show("����������, ��������� ��� ���� � �������� ��������� � ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int categoryId = GetCategoryIdByName(categoryName);

            if (categoryId == -1)
            {
                MessageBox.Show("�� ������� ���������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                AddLotToDatabase(lotname, startPrice, categoryId, sellerId);
                MessageBox.Show("��� ������� ��������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ���������� ����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetClientIdByUsername(string username)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT client_id FROM client WHERE username = @username";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    var result = cmd.ExecuteScalar();

                    return result != DBNull.Value ? (int)result : -1;
                }
            }
        }

        private List<Lot> GetLotsFromDatabase()
        {
            var lots = new List<Lot>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(@"
            SELECT
                l.lot_id,
                l.lot_name,
                c.category_name,
                l.start_price,
                l.current_price,
                l.status,
                s.username AS seller_name,
                b.username AS buyer_name,
                l.bid_count,
                l.final_price
            FROM
                lot l
            JOIN
                category c ON l.category_id = c.category_id
            JOIN
                client s ON l.seller_id = s.client_id
            LEFT JOIN
                client b ON l.buyer_id = b.client_id;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lots.Add(new Lot
                            {
                                LotId = reader.GetInt32(reader.GetOrdinal("lot_id")),
                                LotName = reader.GetString(reader.GetOrdinal("lot_name")),
                                CategoryName = reader.GetString(reader.GetOrdinal("category_name")),
                                StartPrice = reader.GetDecimal(reader.GetOrdinal("start_price")),
                                CurrentPrice = reader.GetDecimal(reader.GetOrdinal("current_price")),
                                Status = reader.GetString(reader.GetOrdinal("status")),
                                SellerName = reader.GetString(reader.GetOrdinal("seller_name")),
                                BuyerName = reader.IsDBNull(reader.GetOrdinal("buyer_name")) ? "�� ������" : reader.GetString(reader.GetOrdinal("buyer_name")),
                                BidCount = reader.GetInt32(reader.GetOrdinal("bid_count")),
                                FinalPrice = reader.GetDecimal(reader.GetOrdinal("final_price"))
                            });
                        }
                    }
                }
            }
            return lots;
        }

        private List<string> GetBuyersFromDatabase()
        {
            var buyers = new List<string>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT username FROM client", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buyers.Add(reader.GetString(reader.GetOrdinal("username")));
                        }
                    }
                }
            }
            return buyers;
        }

        private void LoadBuyersIntoComboBox()
        {
            var buyers = GetBuyersFromDatabase();

            comboBox4.Items.Clear(); // ������� ComboBox ����� ����������� ����� ������

            foreach (var buyer in buyers)
            {
                comboBox4.Items.Add(buyer);
            }
        }

        private void LoadLotsIntoDataGridView()
        {
            var lots = GetLotsFromDatabase();

            dataGridViewLot.Rows.Clear();

            foreach (var lot in lots)
            {
                dataGridViewLot.Rows.Add(
                    lot.LotName,
                    lot.CategoryName,
                    lot.StartPrice.ToString("N2"),
                    lot.CurrentPrice.ToString("N2"),
                    lot.Status,
                    lot.SellerName,
                    lot.BuyerName,
                    lot.BidCount,
                    lot.FinalPrice.ToString("N2")
                );
            }
        }

        private List<Category> GetCategoriesFromDatabase()
        {
            var categories = new List<Category>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT category_id, category_name FROM category", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new Category
                            {
                                CategoryId = reader.GetInt32(reader.GetOrdinal("category_id")),
                                CategoryName = reader.GetString(reader.GetOrdinal("category_name"))
                            });
                        }
                    }
                }
            }
            return categories;
        }

        private void LoadCategoriesIntoComboBox()
        {
            var categories = GetCategoriesFromDatabase();

            comboBox5.Items.Clear(); // ������� ComboBox ����� ����������� ����� ������

            foreach (var category in categories)
            {
                comboBox5.Items.Add(category.CategoryName);
            }
        }

        private int GetCategoryIdByName(string categoryName)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT category_id FROM category WHERE category_name = @categoryName";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("categoryName", categoryName);
                    var result = cmd.ExecuteScalar();

                    return result != DBNull.Value ? (int)result : -1;
                }
            }
        }

        private void AddLotToDatabase(string lotName, decimal startPrice, int categoryId, int sellerId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
            INSERT INTO lot (lot_name, start_price, current_price, final_price, status, category_id, seller_id, bid_count)
            VALUES (@lotName, @startPrice, @startPrice, @startPrice, @status, @categoryId, @sellerId, 0);";

                using (var cmd = new NpgsqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("lotName", lotName);
                    cmd.Parameters.AddWithValue("startPrice", startPrice);
                    cmd.Parameters.AddWithValue("status", "���������"); // ��������� ������
                    cmd.Parameters.AddWithValue("categoryId", categoryId);
                    cmd.Parameters.AddWithValue("sellerId", sellerId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private List<AuctionPaymentInfo> GetAuctionPaymentInfoFromDatabase()
        {
            var auctionPaymentInfos = new List<AuctionPaymentInfo>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(@"
            SELECT
                l.lot_name,
                c.username AS buyer_name,
                l.final_price,
                a.end_datetime,
                p.payment_datetime,
                p.status AS payment_status
            FROM
                lot l
            JOIN
                auction a ON l.auction_id = a.auction_id
            JOIN
                client c ON l.buyer_id = c.client_id
            JOIN
                payment p ON l.payment_id = p.payment_id
            WHERE
                l.status = '�������';", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            auctionPaymentInfos.Add(new AuctionPaymentInfo
                            {
                                LotName = reader.GetString(reader.GetOrdinal("lot_name")),
                                BuyerName = reader.GetString(reader.GetOrdinal("buyer_name")),
                                FinalPrice = reader.GetDecimal(reader.GetOrdinal("final_price")),
                                AuctionEndTime = reader.GetDateTime(reader.GetOrdinal("end_datetime")),
                                PaymentDateTime = reader.GetDateTime(reader.GetOrdinal("payment_datetime")),
                                PaymentStatus = reader.GetString(reader.GetOrdinal("payment_status"))
                            });
                        }
                    }
                }
            }
            return auctionPaymentInfos;
        }

        private void LoadAuctionPaymentInfoIntoDataGridView4()
        {
            var auctionPaymentInfos = GetAuctionPaymentInfoFromDatabase();

            dataGridView4.Rows.Clear(); // ������� DataGridView ����� ����������� ����� ������

            foreach (var info in auctionPaymentInfos)
            {
                dataGridView4.Rows.Add(
                    info.LotName,
                    info.BuyerName,
                    info.FinalPrice.ToString("N2"), // �������������� ����� � 2 ����������� �������
                    info.AuctionEndTime.ToString("dd.MM.yyyy HH:mm"),
                    info.PaymentDateTime.ToString("dd.MM.yyyy HH:mm"),
                    info.PaymentStatus
                );
            }
        }
    }
}