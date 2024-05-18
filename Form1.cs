using System.Windows.Forms;

namespace DatabaseSQLMusicAPP
{
    public partial class Form1 : Form
    {

        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albums = albumsDAO.getAllAlbums();

            albumBindingSource.DataSource = albums;

            dataGridView1.DataSource = albumBindingSource;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/thumb/4/42/Beatles_-_Abbey_Road.jpg/220px-Beatles_-_Abbey_Road.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            pictureBox1.Load(imageURL);



            tracksBindingSource.DataSource = albums[rowClicked].Tracks;

            dataGridView2.DataSource = tracksBindingSource;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add a new item to the database

            Album album = new Album
            {
                AlbumName = txt_albumName.Text,

                ArtistName = txt_artistName.Text,

                year = Int32.Parse(txt_year.Text),

                ImageURL = txt_imageURL.Text,

                Description = txt_Description.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;
            MessageBox.Show("You clicked row " + rowClicked);

            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("id of track is " + trackID);

            AlbumsDAO albumsDao = new AlbumsDAO();

            int result = albumsDao.deleteTrack(trackID);

            MessageBox.Show("Result " + result);

            dataGridView2.DataSource = null;
            albums = albumsDao.getAllAlbums();

        }
    }
}
