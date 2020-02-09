import React, { Component, useState, Fragment } from 'react';
import MovieDetail from './moviedetail'
import MovieUpload from './movieupload'
import { object } from 'prop-types';
const API = 'https://localhost:44380/api/MovieWebApi/';
const UploadAPI = 'https://localhost:44380/api/UploadMovie/';
let Query = '';

class MovieTable extends Component {

    //const MovieTable = props => {
    constructor(props) {
        super(props);
        const initialFormState = { Id: null, ReleaseYear: '', OriginEthnicity: '', Title: '', Cast: '', Genre: '', WikiPage: '', Plot: '', Director: '' }
        this.state = {
            movies: [],
            currentMovie: this.initialFormState,
            isEditing: 0,
            showDetail: false,
            showUpload: false
        };

        this.handleCancelClick = this.handleCancelClick.bind(this);
        this.handleSaveClick = this.handleSaveClick.bind(this);
        this.handleUploadClick = this.handleUploadClick.bind(this);

    }
    handleUploadClick = (selectedFile) => {
        const data = new FormData()
        data.append('files', selectedFile)
        
        let headers = new Headers();
        headers.append('Allow', '*');
        headers.append('Origin', '*');
        headers.append("Access-Control-Allow-Methods", "*");
        headers.append("Access-Control-Allow-Headers", "*") 

        fetch(UploadAPI + "UploadMovies", {
            method: 'post',
            body: data,
            headers: headers
        })
            .then(data => {
                this.setState(state => ({
                    currentMovie: this.initialFormState,
                    isEditing: true,
                    showDetail: true,
                    showUpload: false
                }));
                alert('File uploaded successfully');
            });

    }


    handleSaveClick = (id, updatedMovie) => {
        console.log(updatedMovie);
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');
        headers.append('Accept', 'application/json');
        headers.append('Allow', '*');
        headers.append('Origin', '*');
        headers.append("Access-Control-Allow-Methods", "*");
        headers.append("Access-Control-Allow-Headers", "*")

        let updatedMovieNew = {};
        updatedMovieNew.Id = updatedMovie.id;
        updatedMovieNew.ReleaseYear = updatedMovie.releaseYear;
        updatedMovieNew.OriginEthinicity = updatedMovie.originEthinicity;
        updatedMovieNew.Cast = updatedMovie.cast;
        updatedMovieNew.Genre = updatedMovie.genre;
        updatedMovieNew.WikiPage = updatedMovie.wikiPage;
        updatedMovieNew.Plot = updatedMovie.plot;
        updatedMovieNew.Title = updatedMovie.title;
        updatedMovieNew.Director = updatedMovie.director;

        if (id == null || id == undefined) {
            fetch(API + "PostMovieModel", {
                method: 'post',
                body: JSON.stringify(updatedMovieNew),
                headers: headers
            })
                .then(data => {
                    this.setState(state => ({
                        currentMovie: this.initialFormState,
                        isEditing: true,
                        showDetail: true,
                        showUpload: false
                    }));
                    alert('Record inserted successfully');
                });
        }
        else {
            fetch(API + "PutMovieModel", {
                method: 'put',
                body: JSON.stringify(updatedMovieNew),
                headers: headers
            })
                .then(data => {
                    this.setState(state => ({
                        currentMovie: this.initialFormState,
                        isEditing: true,
                        showDetail: true,
                        showUpload: false
                    }));
                    alert('Record updated successfully');
                });
        }
    }


    handleCancelClick = event => {
        this.setState(state => ({
            currentMovie: this.initialFormState,
            isEditing: 0,
            showDetail: false
        }));
    }

    render() {
        let headers = new Headers();

        headers.append('Content-Type', 'application/json');
        headers.append('Accept', 'application/json');
        headers.append('Allow', '*');
        headers.append('Origin', '*');
        headers.append("Access-Control-Allow-Methods", "*");
        headers.append("Access-Control-Allow-Headers", "*")

        const Search = () => {

            let rlsYear = 'ReleaseYear=' + this.ReleaseYearS.value;
            if (this.ReleaseYearS.value == '' || this.ReleaseYearS.value == null || this.ReleaseYearS.value == undefined)
                rlsYear = 'ReleaseYear=' + 0;
            let originEthnicity = 'OriginEthinicity=' + this.OriginEthnicityS.value;
            let cast = 'Cast=' + this.CastS.value;
            let genre = 'Genre=' + this.GenreS.value;
            let wikiPage = 'WikiPage=' + this.WikiPageS.value;
            let plot = 'Plot=' + this.PlotS.value;
            let title = 'Title=' + this.TitleS.value;
            let direct = 'Director=' + this.DirectorS.value;

            Query = rlsYear + '&' + originEthnicity + '&' + cast + '&' + genre + '&' + wikiPage + '&' + plot + '&' + title + '&' + direct + '&PageIndex=1';
            fetch(API + "SearchMovieModel?" + Query, {
                headers: headers
            })
                .then(response => response.json())
                .then(data => { this.setState({ movies: data }); console.log(data) });
        }

        const handleSearchClick = event => {
            Search();
        }

        const handleResetClick = event => {
            this.ReleaseYearS.value = '';
            this.OriginEthnicityS.value = '';
            this.CastS.value = '';
            this.GenreS.value = '';
            this.WikiPageS.value = '';
            this.PlotS.value = '';
            this.TitleS.value = '';
            this.DirectorS.value = '';

            Search();
        }

        const addRow = (isEnabled) => {
            let movie = { Id: null, ReleaseYear: '', OriginEthnicity: '', Title: '', Cast: '', Genre: '', WikiPage: '', Plot: '', Director: '' }
            this.setState(state => ({
                currentMovie: movie,
                isEditing: !isEnabled,
                showDetail: false,
                showUpload: true
            }));
            console.log('edit clicked')
        }

        const editRow = (movie, isEnabled) => {
            this.setState(state => ({
                currentMovie: movie,
                isEditing: !isEnabled,
                showDetail: true,
                showUpload: false
            }));
            console.log('edit clicked')
        }

        const deleteRow = (id) => {
            if (window.confirm("Are you sure you want to Delete?")) {
                let headers = new Headers();
                headers.append('Content-Type', 'application/json');
                headers.append('Accept', 'application/json');
                headers.append('Allow', '*');
                headers.append('Origin', '*');
                headers.append("Access-Control-Allow-Methods", "*");
                headers.append("Access-Control-Allow-Headers", "*")

                fetch(API + "DeleteMovieModel/" + id, {
                    method: 'delete',
                    headers: headers
                })
                    //.then(response => response.json())
                    .then(data => {
                        this.setState(state => ({
                            currentMovie: this.initialFormState,
                            isEditing: true,
                            showDetail: true,
                            showUpload: false
                        }));
                        alert('Record deleted successfully');
                        Search();
                    });
            }
        }

        let TestChild = 'hello';
        const { movies } = this.state;

        return (<div>
            <div className="divHeading">Search</div>
            <table cellPadding='2' cellSpacing='0' className='TableSearch'>
                <tr>
                    <td>Release Year</td>
                    <td><input name='ReleaseYearS' id='ReleaseYearS' type='text' ref={(input) => this.ReleaseYearS = input}></input> </td>
                    <td>Title</td>
                    <td><input name='TitleS' id='TitleS' type='text' ref={(input) => this.TitleS = input}></input> </td>
                    <td>Origin/Ethnicity</td>
                    <td><input name='OriginEthnicityS' id='OriginEthnicityS' type='text' ref={(input) => this.OriginEthnicityS = input}></input> </td>
                    <td>Cast</td>
                    <td><input name='CastS' id='CastS' type='text' ref={(input) => this.CastS = input}></input> </td>
                </tr>
                <tr>
                    <td>Genre</td>
                    <td><input name='GenreS' id='GenreS' type='text' ref={(input) => this.GenreS = input}></input> </td>
                    <td>Wiki Page</td>
                    <td><input name='WikiPageS' id='WikiPage' type='text' ref={(input) => this.WikiPageS = input}></input> </td>
                    <td>Plot</td>
                    <td><input name='PlotS' id='Plot' type='text' ref={(input) => this.PlotS = input}></input> </td>
                    <td>Director</td>
                    <td><input name='DirectorS' id='DirectorS' type='text' ref={(input) => this.DirectorS = input}></input></td>
                </tr>
                <tr>
                    <td colSpan="8" >
                        <div className="TextAlignRight">
                            <input className="ButtonSearch" type="button" value="Search" onClick={handleSearchClick}></input>
                            &nbsp;<input className="ButtonSearch" type="button" value="Reset" onClick={handleResetClick}></input>  </div></td>

                </tr>
            </table>

            <table cellPadding='2' cellSpacing='0' className='Table'>
                <thead>
                    <tr>
                        <th>RelaseYear</th>
                        <th>Title</th>
                        <th>Origin/Ethnicity</th>
                        <th>Director</th>
                        <th>Cast</th>
                        <th>Genre</th>
                        <th>Wiki Page</th>
                        <th>Plot</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {movies != undefined && movies.length > 0 ? (
                        movies.map(movie => (
                            <tr key={movie.id}>
                                <td>{movie.releaseYear}</td>
                                <td>{movie.title}</td>
                                <td>{movie.originEthinicity}</td>
                                <td>{movie.director}</td>
                                <td>{movie.cast}</td>
                                <td>{movie.genre}</td>
                                <td>{movie.wikiPage}</td>
                                <td>{movie.plot}</td>
                                <td>
                                    <button className="button muted-button" onClick={() => editRow(movie, false)}>Detail</button>
                                    <button className="button muted-button" onClick={() => editRow(movie, true)}>Edit</button>
                                    <button className="button muted-button" onClick={() => deleteRow(movie.id)}>Delete</button>
                                </td>
                            </tr>
                        ))
                    ) : (
                            <tr >
                                <td colSpan={9}>
                                    <div className="TextAlignCenter">
                                        No Movies
                                    </div>
                                </td>
                            </tr>
                        )}
                </tbody>
            </table>
            <table>
                <tr>
                    <td><button className="ButtonSearch" onClick={() => addRow(true)}>Add</button> &nbsp; <button className="ButtonSearch" onClick={() => addRow(true)}>Upload</button></td>
                </tr>
            </table>

            &nbsp;
            <div style={this.state.showDetail ? {} : { display: 'none' }}>
                <MovieDetail currentmovie={this.state.currentMovie} isEditing={this.state.isEditing} TestChild={TestChild} handleSaveClick={this.handleSaveClick} onCancel={this.handleCancelClick}></MovieDetail>
            </div>
            <div style={this.state.showUpload ? {} : { display: 'none' }}>
                <MovieUpload handleUploadClick={this.handleUploadClick} onCancel={this.handleCancelClick}></MovieUpload>
            </div>


        </div>
        )
    }
}


export default MovieTable