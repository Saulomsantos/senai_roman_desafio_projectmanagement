import React, { Component } from 'react';
import { FlatList, Text, View, StyleSheet } from 'react-native';

import api from '../services/api';

class GerenciarTipoUsuario extends Component {

    constructor(props){
        super(props);
        this.state = {
            listaTiposUsuarios: []
        }
    }

    componentDidMount() {
        this._carregaTiposUsuarios();
    }

    _carregaTiposUsuarios = async () => {
        const resposta = await api.get('/Usuarios/tipo');
        const dadosDaApi = resposta.data;
        this.setState({ listaTiposUsuarios : dadosDaApi })
    }

    render() {
        return (
            <View style={styles.container}>
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
                <Text style={styles.flatItemLinha}>{item.Id} - {item.TipoUsuario}</Text>
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
    borderBottomColor: "gray"
  },
});