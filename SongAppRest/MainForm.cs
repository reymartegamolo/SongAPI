/*
 * Created by SharpDevelop.
 * User: GAMOLO
 * Date: 11/24/2020
 * Time: 3:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RestSharp;

namespace SongAppRest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		const string baseUrl = "http://bernardgabon.somee.com";
		IRestClient client = new RestClient(baseUrl);  
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnGetSongClick(object sender, EventArgs e)
		{
		     
			var request = new RestRequest("/api/song", Method.GET);
			
			if(!string.IsNullOrWhiteSpace(txtSearch.Text))
			request.AddQueryParameter("search", txtSearch.Text);
			
			var response = client.Execute<List<Song>>(request);
			var songs = response.Data;
			
			bindingSourceSong.DataSource = songs;
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
			bindingSourceSong.EndEdit();			
			var song = (Song)bindingSourceSong.Current; // Current row/record, Cast to type Song
					
			var request = new RestRequest("/api/Song");		
			if(song.Id > 0)
				// Song has Id, already exists, just update it!							
				request.Method = Method.PUT;		
			else
				// Add new song							
				request.Method = Method.POST;	

			request.RequestFormat = DataFormat.Json;
			request.AddBody(song);
			var response = client.Execute(request);
			
			if(response.StatusCode == HttpStatusCode.OK)
			{
				MessageBox.Show("Successfully saved.");
				//GetSongs(); // refresh
			}				
			else
				MessageBox.Show("Saving failed.");			
		}
		void TabPage2Click(object sender, EventArgs e)
		{
	
		}
	}
}
