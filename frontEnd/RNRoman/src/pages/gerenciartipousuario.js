import React, { Component } from 'react';
import { AsyncStorage, FlatList, Text, View, StyleSheet } from 'react-native';

import api from '../services/api';

class GerenciarTipoUsuario extends Component {

    constructor(props){
        super(props);
        this.state = {
            listaTiposUsuarios: [],
            token: ''
        }
    }

    _buscarDadosDoStorage = async () => {
        try {
          const value = await AsyncStorage.getItem('userToken');
          if (value !== null) {
            this.setState({ token: value });
          }
        } catch (error) {}

        this._carregaTiposUsuarios();
        
      };


    _carregaTiposUsuarios = async () => {

        const resposta = await api.get('/Usuarios/tipo', {
            headers: {
                'Authorization' : 'Bearer ' + (this.state.token)
            }
        }
        );
        const dadosDaApi = resposta.data;
        this.setState({ listaTiposUsuarios : dadosDaApi })
    }

    componentDidMount() {
        this._buscarDadosDoStorage();
    }

    render() {
        return (
            <View style={styles.container}>
                <Text style={paddingTop= 15}>{"Tipos de Usuários".toUpperCase()}</Text>
                <FlatList
                    contentContainerStyle={styles.ConteudoLista}
                    data={this.state.listaTiposUsuarios}
                    keyExtractor={item => item.id}
                    renderItem={this.renderizaItem}
                />
            </View>
        )
    }

    renderizaItem = ({ item }) => (
        <View style={styles.flatItemSeparador}>
            <View style={styles.flatItemContainer}>
                <Text style={styles.flatItemLinha}>{item.id} - {item.tipoUsuario}</Text>
            </View>
        </View>
      );
}

export default GerenciarTipoUsuario;

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
    // linha de separacao do cabecalho
    mainHeaderLine: {
        width: 170,
        paddingTop: 10,
        borderBottomColor: "#999999",
        borderBottomWidth: 0.9
    },
    // conteúdo da lista
    ConteudoLista: {
    paddingTop: 30,
    paddingRight: 50,
    paddingLeft: 50
  },
    // dados do evento de cada item da linha
    flatItemSeparador: {
    flexDirection: "row",
    borderBottomWidth: 0.9,
    borderBottomColor: "gray",
    marginBottom: 10
  },
});